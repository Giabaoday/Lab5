using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Smtp;
using MimeKit;
namespace Bai4_RapPhim
{
    public partial class DatVe : Form
    {
        List<Film> films;
        public class Film
        {
            public string Name { get; set; }
            public string ImageLink { get; set; }
            public string DetailLink { get; set; }
            public string Genre { get; set; }
            public string Duration { get; set; }
        }
        public DatVe(List<Film> listfilms)
        {
            InitializeComponent();
            films = listfilms;
            foreach (var film in films)
            {
                comboBox1.Items.Add(film.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Film filmDuocChon = new Film();
            foreach (var film in films)
            {
                if (film.Name == comboBox1.SelectedItem.ToString())
                {
                    filmDuocChon = film;
                    break;
                }
            }
            int giaVeChuan = 50000;
            int tongtien = 0;
            string gheDuocChon = "";
            int checkBoxCount = 0;
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phim");
                return;
            }
            if (name.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên người đặt vé");
                return;
            }
                   
            //duyệt qua các checkbox nằm trong groupbox
            foreach (Control control in groupBox1.Controls)
            {
                if (control is CheckBox)
                {                  
                    CheckBox checkBox = control as CheckBox;
                    if (checkBox.Checked)
                    {
                        gheDuocChon += checkBox.Text + " ";
                        checkBoxCount++;
                        //nếu checkBox.text là "A1" hoặc "A5" hoặc "B1" hoặc "B5" hoặc "C1" hoặc "C5" thì giá vé sẽ giảm 1/2 so với giá vé chuẩn
                        if (checkBox.Text == "A1" || checkBox.Text == "A5" || checkBox.Text == "B1" || checkBox.Text == "B5" || checkBox.Text == "C1" || checkBox.Text == "C5")
                        {
                            tongtien += giaVeChuan / 2;
                        }
                        else if (checkBox.Text == "A2" || checkBox.Text == "A3" || checkBox.Text == "A4" || checkBox.Text == "C2" || checkBox.Text == "C3" || checkBox.Text == "C4")
                        {
                            tongtien += giaVeChuan;
                        }
                        else
                        {
                            tongtien += giaVeChuan * 2;
                        }
                       
                    }
                }
            }
            if (checkBoxCount == 0)
            {
                MessageBox.Show("Vui lòng chọn ghế");
                return;
            }
            money.Text = tongtien.ToString();
            MessageBox.Show("Đặt vé thành công \nTên khách hàng:" + name.Text + "\n" + "Phim: " + comboBox1.SelectedItem.ToString() + "\n" + "Số ghế đặt: " + gheDuocChon + "\n" + "Tổng tiền: " + tongtien );
            var smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 465, true);
            smtpClient.Authenticate("gbao5252@gmail.com", "xwkh lrdn xduw immd");

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Rạp Phim ABCXYZ", "gbao5252@gmail.com"));
            message.To.Add(new MailboxAddress("", email.Text));
            message.Subject = "Xác nhận đặt vé";
            message.Body = new TextPart("html")
            {
                Text = "<h1>Xác nhận đặt vé</h1><br><h2>Tên khách hàng: " + name.Text + "</h2><br><h2>Phim: " + filmDuocChon.Name + "</h2><br><h2>Số ghế đặt: " + gheDuocChon + "</h2><br><h2>Tổng tiền: " + tongtien + "</h2><br><img src='" + filmDuocChon.ImageLink + "'/>"
            };
            smtpClient.Send(message);
            name.Text = "";
            comboBox1.SelectedItem = null;
            foreach (Control control in groupBox1.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = control as CheckBox;
                    checkBox.Checked = false;
                }
            }
            money.Text = "";
            email.Text = "";


        }
    }
}
