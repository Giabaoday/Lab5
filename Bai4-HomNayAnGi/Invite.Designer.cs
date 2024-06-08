namespace Bai4
{
    partial class Invite
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            textBox1 = new TextBox();
            addButton = new Button();
            listBox1 = new ListBox();
            testButton = new Button();
            label2 = new Label();
            sendButton = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(520, 171);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 185);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Email:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(65, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(349, 27);
            textBox1.TabIndex = 2;
            // 
            // addButton
            // 
            addButton.BackColor = SystemColors.ControlText;
            addButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.ForeColor = SystemColors.ButtonHighlight;
            addButton.Location = new Point(420, 178);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 3;
            addButton.Text = "Thêm";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 218);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(497, 164);
            listBox1.TabIndex = 4;
            // 
            // testButton
            // 
            testButton.BackColor = SystemColors.ControlText;
            testButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            testButton.ForeColor = SystemColors.ButtonHighlight;
            testButton.Location = new Point(12, 388);
            testButton.Name = "testButton";
            testButton.Size = new Size(145, 29);
            testButton.TabIndex = 3;
            testButton.Text = "Kiểm tra kết nối";
            testButton.UseVisualStyleBackColor = false;
            testButton.Click += testButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 433);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 5;
            label2.Text = "Chưa kết nối server";
            // 
            // sendButton
            // 
            sendButton.BackColor = SystemColors.ControlText;
            sendButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sendButton.ForeColor = SystemColors.ButtonHighlight;
            sendButton.Location = new Point(364, 388);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(145, 29);
            sendButton.TabIndex = 3;
            sendButton.Text = "Gửi lời mời";
            sendButton.UseVisualStyleBackColor = false;
            sendButton.Click += sendButton_Click;
            // 
            // Invite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 453);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(sendButton);
            Controls.Add(testButton);
            Controls.Add(addButton);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Name = "Invite";
            Text = "Invite";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox textBox1;
        private Button addButton;
        private ListBox listBox1;
        private Button testButton;
        private Label label2;
        private Button sendButton;
    }
}