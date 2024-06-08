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
using Org.BouncyCastle.Asn1.X500;
using MimeKit;
using Org.BouncyCastle.Asn1.Tsp;
namespace Bai4
{
    public partial class Invite : Form
    {
        string[] infos;
        public Invite(Control control, string info)
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Add(control);
            //split the info string to get the name, address, price and the img url
            infos = info.Split(',');
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            try
            {
                var smtpClient = new SmtpClient();
                smtpClient.Connect("smtp.gmail.com", 465, true);
                smtpClient.Authenticate("gbao5252@gmail.com", "xwkh lrdn xduw immd");
                label2.Text = "Kết nối thành công";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại");
            }

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                var smtpClient = new SmtpClient();
                smtpClient.Connect("smtp.gmail.com", 465, true);
                smtpClient.Authenticate("gbao5252@gmail.com", "xwkh lrdn xduw immd");

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Bao", "gbao5252@gmail.com"));
                foreach (var item in listBox1.Items)
                {
                    message.To.Add(new MailboxAddress("", item.ToString()));
                }
                message.Subject = "Mời bạn ăn cùng";
                message.Body = new TextPart("html")
                {
                    //send the food info to the invited email, includign name, address, price and img url, the name is infos[0], address is infos[2], price is infos[1] and img url is infos[4]
                    Text = "<h1>" + infos[0] + "</h1><br><h2>Địa chỉ: " + infos[2] + "</h2><br><h2>Giá: " + infos[1] + "</h2><br><img src='" + infos[4] + "'/>"

                };
                smtpClient.Send(message);
                MessageBox.Show("Gửi thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gửi thất bại");
            }
        }
    }
}
