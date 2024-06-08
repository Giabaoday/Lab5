namespace Bai4
{
    partial class Emailsetting
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
            groupBox1 = new GroupBox();
            smtpPort = new TextBox();
            imapPort = new TextBox();
            smtp = new TextBox();
            imap = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            password = new TextBox();
            label8 = new Label();
            email = new TextBox();
            label7 = new Label();
            nickname = new TextBox();
            label6 = new Label();
            testButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(223, 46);
            label1.TabIndex = 0;
            label1.Text = "Email Config";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(smtpPort);
            groupBox1.Controls.Add(imapPort);
            groupBox1.Controls.Add(smtp);
            groupBox1.Controls.Add(imap);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(650, 105);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Email server configuration";
            // 
            // smtpPort
            // 
            smtpPort.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smtpPort.Location = new Point(438, 61);
            smtpPort.Name = "smtpPort";
            smtpPort.ReadOnly = true;
            smtpPort.Size = new Size(201, 27);
            smtpPort.TabIndex = 1;
            smtpPort.Text = "465";
            // 
            // imapPort
            // 
            imapPort.Location = new Point(95, 61);
            imapPort.Name = "imapPort";
            imapPort.Size = new Size(201, 27);
            imapPort.TabIndex = 1;
            // 
            // smtp
            // 
            smtp.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smtp.Location = new Point(438, 24);
            smtp.Name = "smtp";
            smtp.ReadOnly = true;
            smtp.Size = new Size(201, 27);
            smtp.TabIndex = 1;
            smtp.Text = "smtp.gmail.com";
            // 
            // imap
            // 
            imap.Location = new Point(95, 24);
            imap.Name = "imap";
            imap.Size = new Size(201, 27);
            imap.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(340, 67);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 0;
            label5.Text = "SMTP PORT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 67);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 0;
            label3.Text = "IMAP PORT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(340, 30);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 0;
            label4.Text = "SMTP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 30);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 0;
            label2.Text = "IMAP";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(password);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(email);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(nickname);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(11, 174);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 137);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Account";
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 9F);
            password.Location = new Point(96, 96);
            password.Name = "password";
            password.PasswordChar = '*';
            password.ReadOnly = true;
            password.Size = new Size(201, 27);
            password.TabIndex = 1;
            password.Text = "xwkh lrdn xduw immd";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(7, 102);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 0;
            label8.Text = "Password:";
            // 
            // email
            // 
            email.Font = new Font("Segoe UI", 9F);
            email.Location = new Point(96, 60);
            email.Name = "email";
            email.ReadOnly = true;
            email.Size = new Size(201, 27);
            email.TabIndex = 1;
            email.Text = "gbao5252@gmail.com";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(7, 65);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 0;
            label7.Text = "Email:";
            // 
            // nickname
            // 
            nickname.Font = new Font("Segoe UI", 9F);
            nickname.Location = new Point(96, 24);
            nickname.Name = "nickname";
            nickname.ReadOnly = true;
            nickname.Size = new Size(201, 27);
            nickname.TabIndex = 1;
            nickname.Text = "Bao";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(7, 30);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 0;
            label6.Text = "Nickname:";
            // 
            // testButton
            // 
            testButton.BackColor = SystemColors.ControlText;
            testButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            testButton.ForeColor = SystemColors.ButtonHighlight;
            testButton.Location = new Point(450, 216);
            testButton.Name = "testButton";
            testButton.Size = new Size(161, 45);
            testButton.TabIndex = 3;
            testButton.Text = "Test connection";
            testButton.UseVisualStyleBackColor = false;
            testButton.Click += testButton_Click;
            // 
            // Emailsetting
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(674, 320);
            Controls.Add(testButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "Emailsetting";
            Text = "Emailsetting";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox smtpPort;
        private TextBox imapPort;
        private TextBox smtp;
        private TextBox imap;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox password;
        private Label label8;
        private TextBox email;
        private Label label7;
        private TextBox nickname;
        private Label label6;
        private Button testButton;
    }
}