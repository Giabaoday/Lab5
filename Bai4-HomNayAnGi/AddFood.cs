using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Bai4
{
    public partial class AddFood : Form
    {
        private string tokentype;
        private string accesstoken;
        public AddFood(string tokentype, string accesstoken)
        {
            InitializeComponent();
            this.tokentype = tokentype;
            this.accesstoken = accesstoken;
        }

        private readonly HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri("http://nt106.uitiot.vn")
        };

        private async void addButton_Click(object sender, EventArgs e)
        {
            string apiURL = "/api/v1/monan/add";
            var data = new
            {
                ten_mon_an = name.Text,
                gia = price.Text,
                mo_ta = description.Text,
                dia_chi = address.Text,
                hinh_anh = imgurl.Text
            };

            string json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, apiURL);
            request.Content = content;
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(tokentype, accesstoken);

            HttpResponseMessage response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Thêm món ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm món ăn thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
