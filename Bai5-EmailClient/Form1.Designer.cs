namespace Bai5_EmailClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            sendMail = new Button();
            login = new Button();
            label2 = new Label();
            label1 = new Label();
            password = new TextBox();
            username = new TextBox();
            groupBox2 = new GroupBox();
            smtpPort = new TextBox();
            imapPort = new TextBox();
            smtp = new TextBox();
            imap = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            listView1 = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(sendMail);
            groupBox1.Controls.Add(login);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(password);
            groupBox1.Controls.Add(username);
            groupBox1.Location = new Point(1, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng nhập";
            // 
            // sendMail
            // 
            sendMail.Location = new Point(12, 92);
            sendMail.Name = "sendMail";
            sendMail.Size = new Size(94, 29);
            sendMail.TabIndex = 2;
            sendMail.Text = "Gửi mail";
            sendMail.UseVisualStyleBackColor = true;
            sendMail.Click += sendMail_Click;
            // 
            // login
            // 
            login.Location = new Point(268, 92);
            login.Name = "login";
            login.Size = new Size(94, 29);
            login.TabIndex = 2;
            login.Text = "Đăng nhập";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 66);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 33);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "Tài khoản:";
            // 
            // password
            // 
            password.Location = new Point(90, 59);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(272, 27);
            password.TabIndex = 0;
            password.Text = "xwkh lrdn xduw immd";
            // 
            // username
            // 
            username.Location = new Point(90, 26);
            username.Name = "username";
            username.Size = new Size(272, 27);
            username.TabIndex = 0;
            username.Text = "gbao5252@gmail.com";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(smtpPort);
            groupBox2.Controls.Add(imapPort);
            groupBox2.Controls.Add(smtp);
            groupBox2.Controls.Add(imap);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(386, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(534, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cài đặt";
            // 
            // smtpPort
            // 
            smtpPort.Location = new Point(346, 59);
            smtpPort.Name = "smtpPort";
            smtpPort.Size = new Size(182, 27);
            smtpPort.TabIndex = 2;
            smtpPort.Text = "465";
            // 
            // imapPort
            // 
            imapPort.Location = new Point(59, 59);
            imapPort.Name = "imapPort";
            imapPort.Size = new Size(202, 27);
            imapPort.TabIndex = 2;
            imapPort.Text = "993";
            // 
            // smtp
            // 
            smtp.Location = new Point(346, 26);
            smtp.Name = "smtp";
            smtp.Size = new Size(182, 27);
            smtp.TabIndex = 2;
            smtp.Text = "smtp.gmail.com";
            // 
            // imap
            // 
            imap.Location = new Point(59, 26);
            imap.Name = "imap";
            imap.Size = new Size(202, 27);
            imap.TabIndex = 2;
            imap.Text = "imap.gmail.com";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(293, 66);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 1;
            label6.Text = "Port:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 66);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 1;
            label4.Text = "Port:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(293, 33);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 1;
            label5.Text = "SMTP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 33);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 1;
            label3.Text = "IMAP:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3, columnHeader4 });
            listView1.Location = new Point(12, 143);
            listView1.Name = "listView1";
            listView1.Size = new Size(908, 324);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "From";
            columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Subject";
            columnHeader3.Width = 350;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Datetime";
            columnHeader4.Width = 250;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 475);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 3;
            label7.Text = "Please login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 504);
            Controls.Add(label7);
            Controls.Add(listView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox password;
        private TextBox username;
        private GroupBox groupBox2;
        private Label label3;
        private Button login;
        private TextBox smtpPort;
        private TextBox imapPort;
        private TextBox smtp;
        private TextBox imap;
        private Label label6;
        private Label label4;
        private Label label5;
        private ListView listView1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label7;
        private Button sendMail;
    }
}
