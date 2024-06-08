using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MailKit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;
namespace Bai5_EmailClient
{
    public partial class SendMail : Form
    {
        string smtpServer = "";
        int smtpPort = 0;
        string username = "";
        string password = "";
        public SendMail(string from, string to, string smtp, int port, string user, string pass)
        {
            InitializeComponent();
            fromtb.Text = from;
            totb.Text = to;
            smtpServer = smtp;
            smtpPort = port;
            username = user;
            password = pass;
        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                attachmenttb.Text = openFileDialog.FileName;
            }

        }

        private void send_Click(object sender, EventArgs e)
        {
            try
            {
                var smtpClient = new SmtpClient();
                smtpClient.Connect(smtpServer, smtpPort, true);
                smtpClient.Authenticate(username, password);
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(nametb.Text, fromtb.Text));
                message.To.Add(new MailboxAddress("", totb.Text));
                message.Subject = subjecttb.Text;
                string type = (htmlCheck.Checked) ? "html" : "plain";
                message.Body = new TextPart(type)
                {
                    Text = richTextBox1.Text
                };

                if (attachmenttb.Text != "")
                {
                    var attachment = new MimePart("image", "jpg")
                    {
                        Content = new MimeContent(File.OpenRead(attachmenttb.Text)),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                        ContentTransferEncoding = ContentEncoding.Base64,
                        FileName = "attachment.jpg"
                    };
                    message.Body = new Multipart("mixed")
                    {
                        message.Body,
                        attachment
                    };
                }
                smtpClient.Send(message);
                MessageBox.Show("Gửi email thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gửi email thất bại");
            }

        }
    }
    
}
