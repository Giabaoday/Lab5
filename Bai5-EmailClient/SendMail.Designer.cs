namespace Bai5_EmailClient
{
    partial class SendMail
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            fromtb = new TextBox();
            nametb = new TextBox();
            totb = new TextBox();
            subjecttb = new TextBox();
            richTextBox1 = new RichTextBox();
            htmlCheck = new CheckBox();
            attachmenttb = new TextBox();
            browse = new Button();
            send = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 25);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 63);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 99);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 0;
            label3.Text = "To:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 139);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 0;
            label4.Text = "Subject:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 179);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 0;
            label5.Text = "Body";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 519);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 0;
            label7.Text = "Attachment:";
            // 
            // fromtb
            // 
            fromtb.Location = new Point(101, 18);
            fromtb.Name = "fromtb";
            fromtb.Size = new Size(557, 27);
            fromtb.TabIndex = 1;
            // 
            // nametb
            // 
            nametb.Location = new Point(101, 56);
            nametb.Name = "nametb";
            nametb.Size = new Size(557, 27);
            nametb.TabIndex = 1;
            // 
            // totb
            // 
            totb.Location = new Point(101, 96);
            totb.Name = "totb";
            totb.Size = new Size(557, 27);
            totb.TabIndex = 1;
            // 
            // subjecttb
            // 
            subjecttb.Location = new Point(101, 136);
            subjecttb.Name = "subjecttb";
            subjecttb.Size = new Size(557, 27);
            subjecttb.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(101, 209);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(557, 291);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // htmlCheck
            // 
            htmlCheck.AutoSize = true;
            htmlCheck.Location = new Point(101, 179);
            htmlCheck.Name = "htmlCheck";
            htmlCheck.Size = new Size(70, 24);
            htmlCheck.TabIndex = 3;
            htmlCheck.Text = "HTML";
            htmlCheck.UseVisualStyleBackColor = true;
            // 
            // attachmenttb
            // 
            attachmenttb.Location = new Point(101, 512);
            attachmenttb.Name = "attachmenttb";
            attachmenttb.Size = new Size(461, 27);
            attachmenttb.TabIndex = 1;
            // 
            // browse
            // 
            browse.Location = new Point(564, 511);
            browse.Name = "browse";
            browse.Size = new Size(94, 29);
            browse.TabIndex = 4;
            browse.Text = "Browse";
            browse.UseVisualStyleBackColor = true;
            browse.Click += browse_Click;
            // 
            // send
            // 
            send.Location = new Point(564, 558);
            send.Name = "send";
            send.Size = new Size(94, 29);
            send.TabIndex = 5;
            send.Text = "Send";
            send.UseVisualStyleBackColor = true;
            send.Click += send_Click;
            // 
            // SendMail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 599);
            Controls.Add(send);
            Controls.Add(browse);
            Controls.Add(htmlCheck);
            Controls.Add(richTextBox1);
            Controls.Add(attachmenttb);
            Controls.Add(subjecttb);
            Controls.Add(totb);
            Controls.Add(nametb);
            Controls.Add(fromtb);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SendMail";
            Text = "SendMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox fromtb;
        private TextBox nametb;
        private TextBox totb;
        private TextBox subjecttb;
        private RichTextBox richTextBox1;
        private CheckBox htmlCheck;
        private TextBox attachmenttb;
        private Button browse;
        private Button send;
    }
}