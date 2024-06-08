namespace Bai4
{
    partial class Login
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
            usernametb = new TextBox();
            label1 = new Label();
            passwordtb = new TextBox();
            label2 = new Label();
            loginButton = new Button();
            label3 = new Label();
            signupLink = new LinkLabel();
            SuspendLayout();
            // 
            // usernametb
            // 
            usernametb.BorderStyle = BorderStyle.FixedSingle;
            usernametb.Location = new Point(248, 43);
            usernametb.Name = "usernametb";
            usernametb.Size = new Size(237, 27);
            usernametb.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 39);
            label1.Name = "label1";
            label1.Size = new Size(178, 31);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập:";
            // 
            // passwordtb
            // 
            passwordtb.BorderStyle = BorderStyle.FixedSingle;
            passwordtb.Location = new Point(248, 97);
            passwordtb.Name = "passwordtb";
            passwordtb.PasswordChar = '*';
            passwordtb.Size = new Size(237, 27);
            passwordtb.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 93);
            label2.Name = "label2";
            label2.Size = new Size(122, 31);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.ActiveCaptionText;
            loginButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = SystemColors.ButtonHighlight;
            loginButton.Location = new Point(298, 130);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(137, 41);
            loginButton.TabIndex = 2;
            loginButton.Text = "Đăng nhập";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 176);
            label3.Name = "label3";
            label3.Size = new Size(162, 20);
            label3.TabIndex = 3;
            label3.Text = "Bạn chưa có tài khoản?";
            // 
            // signupLink
            // 
            signupLink.AutoSize = true;
            signupLink.LinkColor = Color.Black;
            signupLink.Location = new Point(386, 176);
            signupLink.Name = "signupLink";
            signupLink.Size = new Size(99, 20);
            signupLink.TabIndex = 4;
            signupLink.TabStop = true;
            signupLink.Text = "Tạo tài khoản";
            signupLink.VisitedLinkColor = Color.White;
            signupLink.LinkClicked += signupLink_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(643, 214);
            Controls.Add(signupLink);
            Controls.Add(label3);
            Controls.Add(loginButton);
            Controls.Add(label2);
            Controls.Add(passwordtb);
            Controls.Add(label1);
            Controls.Add(usernametb);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernametb;
        private Label label1;
        private TextBox passwordtb;
        private Label label2;
        private Button loginButton;
        private Label label3;
        private LinkLabel signupLink;
    }
}