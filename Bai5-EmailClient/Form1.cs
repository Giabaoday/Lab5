using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;

namespace Bai5_EmailClient
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                
                var imapClient = new ImapClient();
                imapClient.Connect(imap.Text, int.Parse(imapPort.Text), true);
                imapClient.Authenticate(username.Text, password.Text);
                label7.Text = "Đăng nhập thành công";
                //lấy danh sách email sau khi đăng nhập thành công
                var inbox = imapClient.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    ListViewItem item = new ListViewItem(message.From.ToString());
                    item.SubItems.Add(message.Subject);
                    item.SubItems.Add(message.Date.ToString());
                    //đọc textbody dưới dạng html
                    item.SubItems.Add(message.HtmlBody);                   
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại");
            }

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];
                var from = item.SubItems[0].Text;
                var to = username.Text;
                var subject = item.SubItems[1].Text;
                var text = item.SubItems[3].Text;
                ViewEmail viewEmail = new ViewEmail(from, to, subject, text, smtp.Text, int.Parse(smtpPort.Text), username.Text, password.Text);
                viewEmail.Show();
            }
        }

        private void sendMail_Click(object sender, EventArgs e)
        {
            if (label7.Text == "Đăng nhập thành công")
            {
                SendMail sendMail = new SendMail(username.Text, "", smtp.Text, int.Parse(smtpPort.Text), username.Text, password.Text);
                sendMail.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng đăng nhập trước khi gửi email");
            }
        }
    }
}
