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
using MimeKit;
namespace Bai4
{
    public partial class Popup : Form
    {
        int count = 0;
        string info = "";
        public Popup(Control control, string s, int dem)
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Add(control);
            info = s;
            count = dem;
        }

        private void inviteButton_Click(object sender, EventArgs e)
        {
            //show the invite form with the control in the flowlayoutpanel
            Invite invite = new Invite(flowLayoutPanel1.Controls[0], info);
            invite.Show();
        }
    }
}
