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

namespace Bai4
{
    public partial class Foodctl : UserControl
    {
        public Foodctl()
        {
            InitializeComponent();
        }

        public void setname(string s)
        {
            name.Text = s;
        }

        public void setprice(string s)
        {
            price.Text = s;
        }

        public void setaddress(string s)
        {
            address.Text = s;
        }

        public void setcontributor(string s)
        {
            owner.Text = s;
        }
        public void setimage(PictureBox pictureBox)
        {
            if (pictureBox.Image != null && pictureBox != null)
            {
                pictureBox1.Image = (Image)pictureBox.Image.Clone();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Image = null;
                pictureBox1.Visible = false;
            }
        }
    }
}
