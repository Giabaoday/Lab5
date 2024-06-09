namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1.Form1 bai1 = new Bai1.Form1();
            bai1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai2.Form1 bai2 = new Bai2.Form1();
            bai2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai3_RapPhim.Form1 bai3 = new Bai3_RapPhim.Form1();
            bai3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai4.Login bai4 = new Bai4.Login();
            bai4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai5_EmailClient.Form1 bai5 = new Bai5_EmailClient.Form1();
            bai5.Show();
        }
    }
}
