namespace Bai4
{
    partial class Popup
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
            inviteButton = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(1, 1);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(520, 171);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // inviteButton
            // 
            inviteButton.Location = new Point(371, 178);
            inviteButton.Name = "inviteButton";
            inviteButton.Size = new Size(150, 29);
            inviteButton.TabIndex = 1;
            inviteButton.Text = "Mời bạn bè";
            inviteButton.UseVisualStyleBackColor = true;
            inviteButton.Click += inviteButton_Click;
            // 
            // Popup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 210);
            Controls.Add(inviteButton);
            Controls.Add(flowLayoutPanel1);
            Name = "Popup";
            Text = "Món ăn may mắn được chọn là.....";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button inviteButton;
    }
}