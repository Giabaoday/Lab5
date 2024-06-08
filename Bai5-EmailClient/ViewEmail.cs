using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_EmailClient
{
    public partial class ViewEmail : Form
    {
        string smptServer = "";
        int smtpPort = 0;
        string username = "";
        string password = "";
        public ViewEmail(string from, string to, string subject, string text, string smtp, int port, string user, string pass)
        {
            InitializeComponent();
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Dock = DockStyle.Fill;
            panel1.Controls.Add(webBrowser);

            webBrowser.DocumentText = text;
            fromlb.Text = from;
            tolb.Text = to;
            subjectlb.Text = subject;
            smptServer = smtp;
            smtpPort = port;
            username = user;
            password = pass;
        }

        private void reply_Click(object sender, EventArgs e)
        {
            SendMail sendMail = new SendMail(tolb.Text, fromlb.Text.Substring(fromlb.Text.IndexOf('<') + 1, fromlb.Text.IndexOf('>') - fromlb.Text.IndexOf('<') - 1), smptServer, smtpPort, username, password);
            sendMail.Show();
        }
    }
}
