namespace CODSE22F_023
{
    partial class AdminHome
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
            this.users = new System.Windows.Forms.Button();
            this.reports = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // users
            // 
            this.users.BackgroundImage = global::CODSE22F_023.Properties.Resources.Users;
            this.users.Location = new System.Drawing.Point(197, 261);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(122, 144);
            this.users.TabIndex = 0;
            this.users.UseVisualStyleBackColor = true;
            this.users.Click += new System.EventHandler(this.users_Click);
            // 
            // reports
            // 
            this.reports.BackgroundImage = global::CODSE22F_023.Properties.Resources.Reports;
            this.reports.Location = new System.Drawing.Point(424, 149);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(148, 147);
            this.reports.TabIndex = 1;
            this.reports.UseVisualStyleBackColor = true;
            this.reports.Click += new System.EventHandler(this.reports_Click);
            // 
            // logout
            // 
            this.logout.BackgroundImage = global::CODSE22F_023.Properties.Resources.Log_out;
            this.logout.Location = new System.Drawing.Point(439, 415);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(164, 172);
            this.logout.TabIndex = 2;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Order
            // 
            this.Order.BackgroundImage = global::CODSE22F_023.Properties.Resources.Ordered;
            this.Order.Location = new System.Drawing.Point(636, 247);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(222, 176);
            this.Order.TabIndex = 3;
            this.Order.UseVisualStyleBackColor = true;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CODSE22F_023.Properties.Resources.Admin_Portal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 634);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.reports);
            this.Controls.Add(this.users);
            this.Controls.Add(this.Order);
            this.DoubleBuffered = true;
            this.Name = "AdminHome";
            this.Text = "Admin Home";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button users;
        private System.Windows.Forms.Button reports;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button Order;
    }
}