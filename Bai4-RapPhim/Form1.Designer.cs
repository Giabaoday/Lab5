﻿namespace Bai4_RapPhim
{
    partial class Form1
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
            flowLayoutPanelFilmBanners = new FlowLayoutPanel();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanelFilmBanners
            // 
            flowLayoutPanelFilmBanners.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanelFilmBanners.Location = new Point(12, 78);
            flowLayoutPanelFilmBanners.Name = "flowLayoutPanelFilmBanners";
            flowLayoutPanelFilmBanners.Size = new Size(506, 1200);
            flowLayoutPanelFilmBanners.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(125, 29);
            label1.Name = "label1";
            label1.Size = new Size(295, 46);
            label1.TabIndex = 1;
            label1.Text = "Phim Đang Chiếu";
            // 
            // button1
            // 
            button1.Location = new Point(426, 43);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Đặt vé";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 1055);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanelFilmBanners);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelFilmBanners;
        private Label label1;
        private Button button1;
    }
}