namespace Bai4
{
    partial class Main
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            addButton = new Button();
            randomButton = new Button();
            allButton = new Button();
            mineButton = new Button();
            label2 = new Label();
            page = new ComboBox();
            label3 = new Label();
            size = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(267, 46);
            label1.TabIndex = 0;
            label1.Text = "Hôm nay ăn gì?";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(12, 111);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(776, 591);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.BackColor = SystemColors.ActiveCaptionText;
            addButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.ForeColor = SystemColors.ButtonHighlight;
            addButton.Location = new Point(362, 6);
            addButton.Name = "addButton";
            addButton.Size = new Size(210, 45);
            addButton.TabIndex = 2;
            addButton.Text = "Thêm món ăn";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // randomButton
            // 
            randomButton.BackColor = SystemColors.ActiveCaptionText;
            randomButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            randomButton.ForeColor = SystemColors.ButtonHighlight;
            randomButton.Location = new Point(578, 6);
            randomButton.Name = "randomButton";
            randomButton.Size = new Size(210, 45);
            randomButton.TabIndex = 2;
            randomButton.Text = "Tìm món ăn";
            randomButton.UseVisualStyleBackColor = false;
            randomButton.Click += randomButton_Click;
            // 
            // allButton
            // 
            allButton.BackColor = SystemColors.ActiveCaptionText;
            allButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            allButton.ForeColor = SystemColors.ButtonHighlight;
            allButton.Location = new Point(12, 72);
            allButton.Name = "allButton";
            allButton.Size = new Size(122, 33);
            allButton.TabIndex = 2;
            allButton.Text = "Cộng đồng";
            allButton.UseVisualStyleBackColor = false;
            allButton.Click += allButton_Click;
            // 
            // mineButton
            // 
            mineButton.BackColor = SystemColors.ActiveCaptionText;
            mineButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mineButton.ForeColor = SystemColors.ButtonHighlight;
            mineButton.Location = new Point(140, 72);
            mineButton.Name = "mineButton";
            mineButton.Size = new Size(156, 33);
            mineButton.TabIndex = 2;
            mineButton.Text = "Món ăn của tôi";
            mineButton.UseVisualStyleBackColor = false;
            mineButton.Click += mineButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(439, 713);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 3;
            label2.Text = "Trang:";
            // 
            // page
            // 
            page.FormattingEnabled = true;
            page.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            page.Location = new Point(494, 710);
            page.Name = "page";
            page.Size = new Size(70, 28);
            page.TabIndex = 4;
            page.SelectedIndexChanged += page_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(613, 713);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 3;
            label3.Text = "Kích cỡ trang:";
            // 
            // size
            // 
            size.FormattingEnabled = true;
            size.Location = new Point(720, 710);
            size.Name = "size";
            size.Size = new Size(70, 28);
            size.TabIndex = 4;
            size.SelectedIndexChanged += size_SelectedIndexChanged;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 742);
            Controls.Add(size);
            Controls.Add(page);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(randomButton);
            Controls.Add(mineButton);
            Controls.Add(allButton);
            Controls.Add(addButton);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button addButton;
        private Button randomButton;
        private Button allButton;
        private Button mineButton;
        private Label label2;
        private ComboBox page;
        private Label label3;
        private ComboBox size;
    }
}