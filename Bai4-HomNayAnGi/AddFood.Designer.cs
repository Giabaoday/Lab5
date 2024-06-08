namespace Bai4
{
    partial class AddFood
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            name = new TextBox();
            label4 = new Label();
            price = new TextBox();
            label5 = new Label();
            address = new TextBox();
            label3 = new Label();
            imgurl = new TextBox();
            label6 = new Label();
            description = new RichTextBox();
            addButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 9);
            label1.Name = "label1";
            label1.Size = new Size(239, 46);
            label1.TabIndex = 0;
            label1.Text = "Thêm món ăn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(107, 23);
            label2.TabIndex = 1;
            label2.Text = "Tên món ăn:";
            // 
            // name
            // 
            name.BorderStyle = BorderStyle.FixedSingle;
            name.Location = new Point(125, 69);
            name.Name = "name";
            name.Size = new Size(263, 27);
            name.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 113);
            label4.Name = "label4";
            label4.Size = new Size(41, 23);
            label4.TabIndex = 1;
            label4.Text = "Giá:";
            // 
            // price
            // 
            price.BorderStyle = BorderStyle.FixedSingle;
            price.Location = new Point(125, 109);
            price.Name = "price";
            price.Size = new Size(263, 27);
            price.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 154);
            label5.Name = "label5";
            label5.Size = new Size(70, 23);
            label5.TabIndex = 1;
            label5.Text = "Địa chỉ:";
            // 
            // address
            // 
            address.BorderStyle = BorderStyle.FixedSingle;
            address.Location = new Point(125, 150);
            address.Name = "address";
            address.Size = new Size(263, 27);
            address.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 196);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 1;
            label3.Text = "Link ảnh:";
            // 
            // imgurl
            // 
            imgurl.BorderStyle = BorderStyle.FixedSingle;
            imgurl.Location = new Point(125, 192);
            imgurl.Name = "imgurl";
            imgurl.Size = new Size(263, 27);
            imgurl.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 230);
            label6.Name = "label6";
            label6.Size = new Size(62, 23);
            label6.TabIndex = 1;
            label6.Text = "Mô tả:";
            // 
            // description
            // 
            description.BorderStyle = BorderStyle.FixedSingle;
            description.Location = new Point(12, 256);
            description.Name = "description";
            description.Size = new Size(483, 120);
            description.TabIndex = 3;
            description.Text = "";
            // 
            // addButton
            // 
            addButton.BackColor = SystemColors.ControlText;
            addButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.ForeColor = SystemColors.ButtonHighlight;
            addButton.Location = new Point(187, 382);
            addButton.Name = "addButton";
            addButton.Size = new Size(131, 36);
            addButton.TabIndex = 4;
            addButton.Text = "Thêm";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // AddFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(507, 430);
            Controls.Add(addButton);
            Controls.Add(description);
            Controls.Add(imgurl);
            Controls.Add(address);
            Controls.Add(price);
            Controls.Add(name);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddFood";
            Text = "AddFood";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox name;
        private Label label4;
        private TextBox price;
        private Label label5;
        private TextBox address;
        private Label label3;
        private TextBox imgurl;
        private Label label6;
        private RichTextBox description;
        private Button addButton;
    }
}