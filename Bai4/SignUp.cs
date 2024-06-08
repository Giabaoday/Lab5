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
namespace Bai4
{
    public partial class SignUp : Form
    {
        private int sex;
        public SignUp()
        {
            InitializeComponent();
        }

        private async void signupButton_Click(object sender, EventArgs e)
        {
            if (gendercb.SelectedItem.ToString() == "Nam")
            {
                sex = 1;
            }
            else { sex = 0; }

            var userData = new
            {
                username = usernametb.Text,
                password = passwordtb.Text,
                email = emailtb.Text,
                firstname = firstnametb.Text,
                lastname = lastnametb.Text,
                gender = sex,
                birthday = birthday.Text,
                phone = numbertb.Text,
                language = languagecb.SelectedItem.ToString()
            };

            string json = JsonConvert.SerializeObject(userData);

            string apiURL = "https://nt106.uitiot.vn/v1/user/signup";

            using (var httpClient = new HttpClient())
            {
                try
                {
                    var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

                    var httpResponse = await httpClient.PostAsync(apiURL, httpContent);

                    string response = await httpResponse.Content.ReadAsStringAsync();

                    Console.WriteLine($"HTTP Status Code: {httpResponse.StatusCode}");
                    Console.WriteLine($"Respone Content: {response}");
                    this.Close();
                }
                catch
                (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
