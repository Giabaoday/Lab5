namespace Bai5_EmailClient
{
    partial class ViewEmail
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
            fromlb = new Label();
            tolb = new Label();
            reply = new Button();
            subjectlb = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 14);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 46);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 0;
            label2.Text = "To:";
            // 
            // fromlb
            // 
            fromlb.AutoSize = true;
            fromlb.Location = new Point(122, 14);
            fromlb.Name = "fromlb";
            fromlb.Size = new Size(50, 20);
            fromlb.TabIndex = 0;
            fromlb.Text = "label1";
            // 
            // tolb
            // 
            tolb.AutoSize = true;
            tolb.Location = new Point(122, 46);
            tolb.Name = "tolb";
            tolb.Size = new Size(50, 20);
            tolb.TabIndex = 0;
            tolb.Text = "label1";
            // 
            // reply
            // 
            reply.Location = new Point(685, 14);
            reply.Name = "reply";
            reply.Size = new Size(94, 29);
            reply.TabIndex = 1;
            reply.Text = "Reply";
            reply.UseVisualStyleBackColor = true;
            reply.Click += reply_Click;
            // 
            // subjectlb
            // 
            subjectlb.AutoSize = true;
            subjectlb.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subjectlb.Location = new Point(12, 89);
            subjectlb.Name = "subjectlb";
            subjectlb.Size = new Size(96, 38);
            subjectlb.TabIndex = 0;
            subjectlb.Text = "label1";
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(764, 375);
            panel1.TabIndex = 2;
            // 
            // ViewEmail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 515);
            Controls.Add(panel1);
            Controls.Add(reply);
            Controls.Add(tolb);
            Controls.Add(subjectlb);
            Controls.Add(label2);
            Controls.Add(fromlb);
            Controls.Add(label1);
            Name = "ViewEmail";
            Text = "ViewEmail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label fromlb;
        private Label tolb;
        private Button reply;
        private Label subjectlb;
        private Panel panel1;
    }
}