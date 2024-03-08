namespace SaleManagementWinApp
{
    partial class frmAdmin
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
            menuStrip1 = new MenuStrip();
            tsmCustomer = new ToolStripMenuItem();
            tsmProduct = new ToolStripMenuItem();
            tsmOrder = new ToolStripMenuItem();
            tsmCreateOrder = new ToolStripMenuItem();
            tsmManageOrder = new ToolStripMenuItem();
            tsmStatistics = new ToolStripMenuItem();
            tsmLogout = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmCustomer, tsmProduct, tsmOrder, tsmStatistics, tsmLogout });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmCustomer
            // 
            tsmCustomer.Name = "tsmCustomer";
            tsmCustomer.Size = new Size(178, 24);
            tsmCustomer.Text = "Customer Management";
            tsmCustomer.Click += tsmCustomer_Click;
            // 
            // tsmProduct
            // 
            tsmProduct.Name = "tsmProduct";
            tsmProduct.Size = new Size(166, 24);
            tsmProduct.Text = "Product Management";
            tsmProduct.Click += tsmProduct_Click;
            // 
            // tsmOrder
            // 
            tsmOrder.DropDownItems.AddRange(new ToolStripItem[] { tsmCreateOrder, tsmManageOrder });
            tsmOrder.Name = "tsmOrder";
            tsmOrder.Size = new Size(153, 24);
            tsmOrder.Text = "Order Management";
            // 
            // tsmCreateOrder
            // 
            tsmCreateOrder.Name = "tsmCreateOrder";
            tsmCreateOrder.Size = new Size(194, 26);
            tsmCreateOrder.Text = "Create A Order";
            tsmCreateOrder.Click += tsmCreateOrder_Click;
            // 
            // tsmManageOrder
            // 
            tsmManageOrder.Name = "tsmManageOrder";
            tsmManageOrder.Size = new Size(194, 26);
            tsmManageOrder.Text = "Manage Orders";
            tsmManageOrder.Click += tsmManagerOrder_Click;
            // 
            // tsmStatistics
            // 
            tsmStatistics.Name = "tsmStatistics";
            tsmStatistics.Size = new Size(81, 24);
            tsmStatistics.Text = "Statistics";
            tsmStatistics.Click += tsmStatistics_Click;
            // 
            // tsmLogout
            // 
            tsmLogout.Name = "tsmLogout";
            tsmLogout.Size = new Size(76, 24);
            tsmLogout.Text = "Log Out";
            tsmLogout.Click += tsmLogout_Click;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmAdmin";
            Text = "System Management";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmCustomer;
        private ToolStripMenuItem tsmProduct;
        private ToolStripMenuItem tsmOrder;
        private ToolStripMenuItem tsmStatistics;
        private ToolStripMenuItem tsmLogout;
        private ToolStripMenuItem tsmCreateOrder;
        private ToolStripMenuItem tsmManageOrder;
    }
}