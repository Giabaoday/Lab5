using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json.Linq;
namespace Bai4
{
    public partial class Login : Form
    {
        private string tokentype;
        private string accesstoken;

        public string Tokentype { get => tokentype; set => tokentype = value; }
        public string AccessToken { get => accesstoken; set => accesstoken = value; }
        public Login()
        {
            InitializeComponent();
        }

        private readonly HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };
        private async void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernametb.Text;
            string password = passwordtb.Text;

            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)
            });

            HttpResponseMessage response = await client.PostAsync("auth/token", formContent);
            using (response)
            {
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    JObject jObject = JObject.Parse(responseContent);
                    if (jObject["access_token"] != null)
                    {
                        tokentype = jObject["token_type"].ToString();
                        accesstoken = jObject["access_token"].ToString();
                    }
                    Main main = new Main(tokentype, accesstoken);
                    main.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc Mật khẩu chưa đúng. Xin vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void signupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();

        }
    }
}
