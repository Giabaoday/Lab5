using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
namespace Bai3_RapPhim
{
    public partial class Form1 : Form
    {
        private List<Film> films = new List<Film>();
        private ProgressBar progressBar;

        public Form1()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var htmlWeb = new HtmlWeb();
            var document = htmlWeb.Load("https://betacinemas.vn/phim.htm");


            var filmNodes = document.DocumentNode.SelectNodes("//div[contains(@class, 'col-lg-4') and contains(@class, 'col-md-4') and contains(@class, 'col-sm-8') and contains(@class, 'col-xs-16')]");


            progressBar = new ProgressBar();
            progressBar.Minimum = 0;
            progressBar.Maximum = filmNodes.Count;
            progressBar.Step = 1;
            progressBar.Dock = DockStyle.Top;
            progressBar.Visible = true;
            this.Controls.Add(progressBar);

            if (filmNodes != null)
            {
                foreach (var filmNode in filmNodes)
                {
                    var filmName = filmNode.SelectSingleNode(".//h3/a").InnerText;
                    var filmImageLink = filmNode.SelectSingleNode(".//img").Attributes["src"].Value;
                    var filmDetailLink = filmNode.SelectSingleNode(".//h3/a").Attributes["href"].Value;
                    var filmGenre = filmNode.SelectSingleNode(".//li[contains(span, 'Thể loại')]").InnerText;
                    var filmDuration = filmNode.SelectSingleNode(".//li[contains(span, 'Thời lượng')]").InnerText;


                    films.Add(new Film { Name = filmName, ImageLink = filmImageLink, DetailLink = "https://betacinemas.vn" + filmDetailLink, Genre = filmGenre, Duration = filmDuration });


                    progressBar.PerformStep();
                }
            }

            // Display film information (create controls dynamically)
            foreach (var film in films)
            {
                var filmPanel = new Panel(); // Create a panel to wrap the film banner
                filmPanel.Width = 500; // Set the width of the panel
                filmPanel.Height = 120; // Set the height of the panel
                filmPanel.BorderStyle = BorderStyle.FixedSingle; // Set the border style for the panel

                var filmBanner = new FilmBannerControl(film.Name, film.ImageLink, film.DetailLink);
                filmBanner.DetailLinkClicked += FilmBanner_DetailLinkClicked; // Subscribe to the event
                filmPanel.Controls.Add(filmBanner); // Add the film banner control to the panel

                flowLayoutPanelFilmBanners.FlowDirection = FlowDirection.TopDown;
                flowLayoutPanelFilmBanners.Controls.Add(filmPanel); // Add the panel to the flow layout panel
            }

            // Save films to JSON
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(films, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("films.json", json);
        }

        private void FilmBanner_DetailLinkClicked(object sender, EventArgs e)
        {
            var filmBanner = (FilmBannerControl)sender;
            var detailLink = filmBanner.DetailLink;

            // Open the detail link in another form
            var detailForm = new FilmDetailForm(detailLink);
            detailForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatVe datVe = new DatVe(films.Select(f => new DatVe.Film { Name = f.Name, ImageLink = f.ImageLink, DetailLink = f.DetailLink, Genre = f.Genre, Duration = f.Duration }).ToList());
            datVe.Show();
        }
    }

    public class Film
    {
        public string Name { get; set; }
        public string ImageLink { get; set; }
        public string DetailLink { get; set; }
        public string Genre { get; set; }
        public string Duration { get; set; }
    }

    public class FilmBannerControl : UserControl
    {
        private PictureBox pictureBoxFilm;
        private Label labelFilmName;
        private LinkLabel linkLabelDetail;
        private Button buttonDetail;

        public event EventHandler DetailLinkClicked;

        public string DetailLink { get; private set; }

        public FilmBannerControl(string filmName, string imageLink, string detailLink)
        {
            
            pictureBoxFilm = new PictureBox();
            labelFilmName = new Label();
            linkLabelDetail = new LinkLabel();
            buttonDetail = new Button();

            // Set properties for PictureBox (film image)
            pictureBoxFilm.ImageLocation = imageLink;
            pictureBoxFilm.SizeMode = PictureBoxSizeMode.Zoom;

            
            labelFilmName.Text = filmName;

            // Set properties for LinkLabel (detail link)
            linkLabelDetail.Text = detailLink;
            linkLabelDetail.Tag = detailLink;
            linkLabelDetail.LinkClicked += LinkLabelDetail_LinkClicked;

            
            buttonDetail.Text = labelFilmName.Text;
            buttonDetail.FlatStyle = FlatStyle.Popup;
            buttonDetail.BackColor = Color.Transparent;
            buttonDetail.FlatAppearance.BorderSize = 0;
            buttonDetail.Dock = DockStyle.Fill; 
            buttonDetail.Click += ButtonDetail_Click;
            buttonDetail.Width = 500;
            buttonDetail.Height = 120;

            
            this.Controls.Add(buttonDetail);
            this.Controls.Add(pictureBoxFilm);
            this.Controls.Add(labelFilmName);
            this.Controls.Add(linkLabelDetail);
            

            pictureBoxFilm.Dock = DockStyle.Left;
            labelFilmName.Dock = DockStyle.Fill;
            linkLabelDetail.Dock = DockStyle.Bottom;
            

            this.Width = 500; 
            this.Height = 120; 

            DetailLink = detailLink;
        }

        private void ButtonDetail_Click(object sender, EventArgs e)
        {
            DetailLinkClicked?.Invoke(this, EventArgs.Empty);
        }    

        private void LinkLabelDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var linkLabel = (LinkLabel)sender;
            var detailLink = linkLabel.Text.ToString();

            DetailLinkClicked?.Invoke(this, EventArgs.Empty);
        }
    }


    public class FilmDetailForm : Form
    {
        public FilmDetailForm(string detailLink)
        {
            // Open the detail link in a web browser control
            var webBrowser = new WebBrowser();
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.Navigate(detailLink);

            this.Controls.Add(webBrowser);
        }
    }
}
