namespace SaleManagementWinApp
{
    partial class frmAccount
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
            menuStrip2 = new MenuStrip();
            tsmMyProfile = new ToolStripMenuItem();
            tsmViewOrderHistory = new ToolStripMenuItem();
            tsmLogout = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { tsmMyProfile, tsmViewOrderHistory, tsmLogout });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 28);
            menuStrip2.TabIndex = 0;
            menuStrip2.Text = "menuStrip2";
            // 
            // tsmMyProfile
            // 
            tsmMyProfile.Name = "tsmMyProfile";
            tsmMyProfile.Size = new Size(90, 24);
            tsmMyProfile.Text = "My Profile";
            tsmMyProfile.Click += tsmMyProfile_Click;
            // 
            // tsmViewOrderHistory
            // 
            tsmViewOrderHistory.Name = "tsmViewOrderHistory";
            tsmViewOrderHistory.Size = new Size(148, 24);
            tsmViewOrderHistory.Text = "View Order History";
            tsmViewOrderHistory.Click += tsmViewOrderHistory_Click;
            // 
            // tsmLogout
            // 
            tsmLogout.Name = "tsmLogout";
            tsmLogout.Size = new Size(76, 24);
            tsmLogout.Text = "Log Out";
            tsmLogout.Click += tsmLogout_Click;
            // 
            // frmAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip2;
            Name = "frmAccount";
            Text = "My Account";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem myProfileToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem createAOrderToolStripMenuItem;
        private ToolStripMenuItem viewOrderHistoryToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem tsmMyProfile;
        private ToolStripMenuItem tsmViewOrderHistory;
        private ToolStripMenuItem tsmLogout;
    }
}