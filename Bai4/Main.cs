using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Bai4
{
    public partial class Main : Form
    {

        private string tokentype;
        private string accesstoken;
        private int count = 0;
        List<string> infos = new List<string>();
        private string info = "";
        private int dem = 0;
        public Main(string token_type, string access_token)
        {
            InitializeComponent();
            this.tokentype = token_type;
            this.accesstoken = access_token;
            DisplayFoods();

        }

        private readonly HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri("http://nt106.uitiot.vn")
        };

        public class FoodResponse
        {
            public List<Food> data { get; set; }
        }

        public class Food
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("ten_mon_an")]
            public string TenMonAn { get; set; }

            [JsonProperty("gia")]
            public decimal Gia { get; set; }

            [JsonProperty("mo_ta")]
            public string MoTa { get; set; }

            [JsonProperty("hinh_anh")]
            public string HinhAnh { get; set; }

            [JsonProperty("dia_chi")]
            public string DiaChi { get; set; }

            [JsonProperty("nguoi_dong_gop")]
            public string NguoiDongGop { get; set; }
        }

        public async void DisplayFoods()
        {
            string apiURL = "https://nt106.uitiot.vn/api/v1/monan/all";
            var requestData = new
            {
                currentPage = 1,
                pageSize = 10
            };
            string json = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, apiURL);
            request.Content = content;
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(tokentype, accesstoken);

            HttpResponseMessage response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                FoodResponse foodResponse = JsonConvert.DeserializeObject<FoodResponse>(responseContent);

                foreach (var food in foodResponse.data)
                {
                    string monan = food.TenMonAn;
                    string gia = food.Gia.ToString();
                    string diachi = food.DiaChi;
                    string nguoidonggop = food.NguoiDongGop;
                    string img = food.HinhAnh;
                    PictureBox pb = new PictureBox();
                    pb.Load(img);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    string infomation = monan + "," + gia + ", " + diachi + ", " + nguoidonggop + "," + img;
                    infos.Add(infomation);
                    Addprogressbar(monan, gia, diachi, nguoidonggop, pb);
                }
            }
            else
            {
                MessageBox.Show("Lỗi kết nối đến server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Addprogressbar(string monan, string gia, string diachi, string nguoidonggop, PictureBox picturebox)
        {
            Foodctl food = new Foodctl();
            food.setname(monan);
            food.setprice(gia);
            food.setaddress(diachi);
            food.setcontributor(nguoidonggop);
            food.setimage(picturebox);
            flowLayoutPanel1.Controls.Add(food);
        }

        public Control GetRandomControl()
        {
            Control randomControl = null;
            List<Control> controls = flowLayoutPanel1.Controls.Cast<Control>().ToList();

            if (controls.Count > 0)
            {
                Random random = new Random();
                int index = random.Next(0, controls.Count);
                randomControl = controls[index];
                info = infos[index];
            }
            return randomControl;
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            Control randomControl = GetRandomControl();
            if (randomControl != null)
            {
                Popup popup = new Popup(randomControl, info, dem);
                popup.Show();
                
            }
            else
            {
                MessageBox.Show("Không có món ăn nào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddFood addFood = new AddFood(tokentype, accesstoken);
            addFood.Show();
        }

        private async void allButton_Click(object sender, EventArgs e)
        {
            count = 0;
            await HandleRequest();
        }

        private async void mineButton_Click(object sender, EventArgs e)
        {
            count = 1;
            await HandleRequest();
        }

        private async void page_SelectedIndexChanged(object sender, EventArgs e)
        {
            await HandleRequest();
        }

        private async void size_SelectedIndexChanged(object sender, EventArgs e)
        {
            await HandleRequest();
        }

        private async Task HandleRequest()
        {
            if (page.SelectedItem == null || size.SelectedItem == null)
            {
                return;
            }

            int currentPage = int.Parse(page.SelectedItem.ToString());
            int pageSize = int.Parse(size.SelectedItem.ToString());

            string apiURL = (count == 0) ? "https://nt106.uitiot.vn/api/v1/monan/all" : "https://nt106.uitiot.vn/api/v1/monan/my-dishes";
            await SendRequest(apiURL, currentPage, pageSize);
        }

        private async Task SendRequest(string apiURL, int currentPage, int pageSize)
        {
            var requestData = new
            {
                currentPage = currentPage,
                pageSize = pageSize
            };
            string json = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, apiURL);
            request.Content = content;
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(tokentype, accesstoken);

            HttpResponseMessage response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                FoodResponse foodResponse = JsonConvert.DeserializeObject<FoodResponse>(responseContent);

                flowLayoutPanel1.Controls.Clear();
                infos.Clear();

                foreach (var food in foodResponse.data)
                {
                    string monan = food.TenMonAn;
                    string gia = food.Gia.ToString();
                    string diachi = food.DiaChi;
                    string nguoidonggop = food.NguoiDongGop;
                    string img = food.HinhAnh;
                    PictureBox pb = new PictureBox();
                    pb.Load(img);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    string infomation = monan + "," + gia + ", " + diachi + ", " + nguoidonggop + "," + img;
                    infos.Add(infomation);
                    Addprogressbar(monan, gia, diachi, nguoidonggop, pb);
                }
            }
            else
            {
                MessageBox.Show("Lỗi kết nối đến server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
    }
}
