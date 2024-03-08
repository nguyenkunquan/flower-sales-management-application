namespace SaleManagementWinApp
{
    partial class frmStatistics
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
            lblStarDate = new Label();
            lblEndDate = new Label();
            lblTotalOrders = new Label();
            lblTotalPrice = new Label();
            dgvStatistics = new DataGridView();
            btnSort = new Button();
            dtpStarDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            txtTotalPrice = new TextBox();
            txtToltalOrders = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvStatistics).BeginInit();
            SuspendLayout();
            // 
            // lblStarDate
            // 
            lblStarDate.AutoSize = true;
            lblStarDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblStarDate.Location = new Point(49, 35);
            lblStarDate.Name = "lblStarDate";
            lblStarDate.Size = new Size(84, 23);
            lblStarDate.TabIndex = 0;
            lblStarDate.Text = "Star Date:";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblEndDate.Location = new Point(49, 84);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(84, 23);
            lblEndDate.TabIndex = 1;
            lblEndDate.Text = "End Date:";
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.AutoSize = true;
            lblTotalOrders.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalOrders.Location = new Point(49, 418);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(106, 23);
            lblTotalOrders.TabIndex = 2;
            lblTotalOrders.Text = "Total Orders:";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPrice.Location = new Point(49, 373);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(95, 25);
            lblTotalPrice.TabIndex = 3;
            lblTotalPrice.Text = "Total Price:";
            // 
            // dgvStatistics
            // 
            dgvStatistics.AllowUserToAddRows = false;
            dgvStatistics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStatistics.Location = new Point(49, 126);
            dgvStatistics.Name = "dgvStatistics";
            dgvStatistics.RowHeadersWidth = 51;
            dgvStatistics.RowTemplate.Height = 29;
            dgvStatistics.Size = new Size(926, 184);
            dgvStatistics.TabIndex = 4;
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.Gold;
            btnSort.Location = new Point(275, 316);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(189, 29);
            btnSort.TabIndex = 5;
            btnSort.Text = "Sort sales";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click;
            // 
            // dtpStarDate
            // 
            dtpStarDate.Location = new Point(167, 34);
            dtpStarDate.Name = "dtpStarDate";
            dtpStarDate.Size = new Size(250, 27);
            dtpStarDate.TabIndex = 6;
            dtpStarDate.ValueChanged += dtpStarDate_ValueChanged;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(167, 83);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 27);
            dtpEndDate.TabIndex = 7;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Enabled = false;
            txtTotalPrice.Location = new Point(167, 374);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(125, 27);
            txtTotalPrice.TabIndex = 8;
            // 
            // txtToltalOrders
            // 
            txtToltalOrders.Enabled = false;
            txtToltalOrders.Location = new Point(167, 417);
            txtToltalOrders.Name = "txtToltalOrders";
            txtToltalOrders.Size = new Size(125, 27);
            txtToltalOrders.TabIndex = 9;
            // 
            // frmStatistics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1014, 469);
            Controls.Add(txtToltalOrders);
            Controls.Add(txtTotalPrice);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStarDate);
            Controls.Add(btnSort);
            Controls.Add(dgvStatistics);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblTotalOrders);
            Controls.Add(lblEndDate);
            Controls.Add(lblStarDate);
            Name = "frmStatistics";
            Text = "Report Statistics";
            Load += frmStatistics_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStatistics).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStarDate;
        private Label lblEndDate;
        private Label lblTotalOrders;
        private Label lblTotalPrice;
        private DataGridView dgvStatistics;
        private Button btnSort;
        private DateTimePicker dtpStarDate;
        private DateTimePicker dtpEndDate;
        private TextBox txtTotalPrice;
        private TextBox txtToltalOrders;
    }
}