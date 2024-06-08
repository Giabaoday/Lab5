namespace Bai4
{
    partial class Foodctl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            name = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            price = new Label();
            address = new Label();
            owner = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 153);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(169, 0);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(321, 153);
            progressBar1.TabIndex = 1;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.Location = new Point(177, 8);
            name.Name = "name";
            name.Size = new Size(70, 28);
            name.TabIndex = 2;
            name.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(177, 46);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 2;
            label2.Text = "Giá:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(177, 81);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(177, 120);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 2;
            label4.Text = "Người đóng góp:";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price.Location = new Point(315, 46);
            price.Name = "price";
            price.Size = new Size(30, 20);
            price.TabIndex = 2;
            price.Text = "gia";
            // 
            // address
            // 
            address.AutoSize = true;
            address.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            address.Location = new Point(315, 81);
            address.Name = "address";
            address.Size = new Size(54, 20);
            address.TabIndex = 2;
            address.Text = "dia chi";
            // 
            // owner
            // 
            owner.AutoSize = true;
            owner.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            owner.Location = new Point(315, 120);
            owner.Name = "owner";
            owner.Size = new Size(76, 20);
            owner.TabIndex = 2;
            owner.Text = "dong gop";
            // 
            // Food
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(owner);
            Controls.Add(address);
            Controls.Add(price);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Name = "Food";
            Size = new Size(493, 153);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private Label name;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label price;
        private Label address;
        private Label owner;
    }
}
