﻿namespace CODSE22F_023
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.addlbl = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(39, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1011, 198);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // addlbl
            // 
            this.addlbl.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.addlbl.AutoSize = true;
            this.addlbl.BackColor = System.Drawing.Color.Transparent;
            this.addlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addlbl.LinkColor = System.Drawing.SystemColors.ControlText;
            this.addlbl.Location = new System.Drawing.Point(439, 500);
            this.addlbl.Name = "addlbl";
            this.addlbl.Size = new System.Drawing.Size(193, 39);
            this.addlbl.TabIndex = 1;
            this.addlbl.TabStop = true;
            this.addlbl.Text = "Order Item";
            this.addlbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addlbl_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.BackgroundImage = global::CODSE22F_023.Properties.Resources._7491940_ui_switch_power_onpower_off_icon__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Image = global::CODSE22F_023.Properties.Resources._7491940_ui_switch_power_onpower_off_icon__1_;
            this.button1.Location = new System.Drawing.Point(54, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 96);
            this.button1.TabIndex = 2;
            this.button1.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nLog out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CODSE22F_023.Properties.Resources.Home;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 617);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addlbl);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel addlbl;
        private System.Windows.Forms.Button button1;
    }
}