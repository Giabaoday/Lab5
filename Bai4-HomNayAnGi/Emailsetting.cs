using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using Bai4.Properties;
namespace Bai4
{
    public partial class Emailsetting : Form
    {
        public Emailsetting()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            try
            {
                var smtpClient = new SmtpClient();
                smtpClient.Connect(smtp.Text, Convert.ToInt32(smtpPort.Text), true);
                smtpClient.Authenticate(email.Text, password.Text);
                MessageBox.Show("Kết nối thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại");
            }
        }

    }
}
