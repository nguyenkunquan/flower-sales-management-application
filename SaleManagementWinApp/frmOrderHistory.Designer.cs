namespace SaleManagementWinApp
{
    partial class frmOrderHistory
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
            dgvOrderHistory = new DataGridView();
            lblTitle = new Label();
            lbl1 = new Label();
            btnView = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderHistory).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderHistory
            // 
            dgvOrderHistory.AllowUserToAddRows = false;
            dgvOrderHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderHistory.Location = new Point(33, 68);
            dgvOrderHistory.Name = "dgvOrderHistory";
            dgvOrderHistory.ReadOnly = true;
            dgvOrderHistory.RowHeadersWidth = 51;
            dgvOrderHistory.RowTemplate.Height = 29;
            dgvOrderHistory.Size = new Size(798, 359);
            dgvOrderHistory.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(46, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 20);
            lblTitle.TabIndex = 1;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.ForeColor = Color.Transparent;
            lbl1.Location = new Point(12, 15);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(96, 38);
            lbl1.TabIndex = 2;
            lbl1.Text = "label1";
            // 
            // btnView
            // 
            btnView.Location = new Point(326, 444);
            btnView.Name = "btnView";
            btnView.Size = new Size(197, 29);
            btnView.TabIndex = 3;
            btnView.Text = "View Order Details";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // frmOrderHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(882, 496);
            Controls.Add(btnView);
            Controls.Add(lbl1);
            Controls.Add(lblTitle);
            Controls.Add(dgvOrderHistory);
            Name = "frmOrderHistory";
            Text = "Your Orders History";
            Load += frmOrderHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrderHistory;
        private Label lblTitle;
        private Label lbl1;
        private Button btnView;
    }
}