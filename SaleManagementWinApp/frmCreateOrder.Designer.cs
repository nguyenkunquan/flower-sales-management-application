namespace SaleManagementWinApp
{
    partial class frmCreateOrder
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
            btnDeleteOrder = new Button();
            btnUpdateOrderDetail = new Button();
            btnCreateOrder = new Button();
            grbCreateOrder = new GroupBox();
            cboCusId = new ComboBox();
            txtCusStatus = new TextBox();
            lblCusStatsus = new Label();
            txtCusName = new TextBox();
            lblCusName = new Label();
            lblCusId = new Label();
            dgvOrderDetail = new DataGridView();
            label1 = new Label();
            btnCreateOrderDetail = new Button();
            btnDeleteOrderDetail = new Button();
            lblTotalOrderDetail = new Label();
            lblTotalPrice = new Label();
            grbCreateOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.BackColor = Color.Firebrick;
            btnDeleteOrder.ForeColor = Color.Transparent;
            btnDeleteOrder.Location = new Point(264, 208);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(110, 29);
            btnDeleteOrder.TabIndex = 33;
            btnDeleteOrder.Text = "Delete order";
            btnDeleteOrder.UseVisualStyleBackColor = false;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // btnUpdateOrderDetail
            // 
            btnUpdateOrderDetail.BackColor = Color.DodgerBlue;
            btnUpdateOrderDetail.ForeColor = Color.Transparent;
            btnUpdateOrderDetail.Location = new Point(777, 388);
            btnUpdateOrderDetail.Name = "btnUpdateOrderDetail";
            btnUpdateOrderDetail.Size = new Size(167, 35);
            btnUpdateOrderDetail.TabIndex = 32;
            btnUpdateOrderDetail.Text = "Update order detail";
            btnUpdateOrderDetail.UseVisualStyleBackColor = false;
            btnUpdateOrderDetail.Click += btnUpdateOrderDetail_Click;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.BackColor = Color.Yellow;
            btnCreateOrder.ForeColor = Color.Black;
            btnCreateOrder.Location = new Point(104, 208);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(110, 29);
            btnCreateOrder.TabIndex = 31;
            btnCreateOrder.Text = "Create order";
            btnCreateOrder.UseVisualStyleBackColor = false;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // grbCreateOrder
            // 
            grbCreateOrder.BackColor = Color.DarkCyan;
            grbCreateOrder.Controls.Add(cboCusId);
            grbCreateOrder.Controls.Add(txtCusStatus);
            grbCreateOrder.Controls.Add(lblCusStatsus);
            grbCreateOrder.Controls.Add(txtCusName);
            grbCreateOrder.Controls.Add(lblCusName);
            grbCreateOrder.Controls.Add(lblCusId);
            grbCreateOrder.ForeColor = Color.White;
            grbCreateOrder.Location = new Point(16, 29);
            grbCreateOrder.Name = "grbCreateOrder";
            grbCreateOrder.Size = new Size(434, 164);
            grbCreateOrder.TabIndex = 30;
            grbCreateOrder.TabStop = false;
            grbCreateOrder.Text = "Order information";
            // 
            // cboCusId
            // 
            cboCusId.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCusId.FormattingEnabled = true;
            cboCusId.Location = new Point(154, 43);
            cboCusId.Name = "cboCusId";
            cboCusId.Size = new Size(251, 28);
            cboCusId.TabIndex = 24;
            cboCusId.SelectedValueChanged += cboCusId_SelectedValueChanged;
            // 
            // txtCusStatus
            // 
            txtCusStatus.Enabled = false;
            txtCusStatus.Location = new Point(154, 115);
            txtCusStatus.Name = "txtCusStatus";
            txtCusStatus.Size = new Size(251, 27);
            txtCusStatus.TabIndex = 23;
            // 
            // lblCusStatsus
            // 
            lblCusStatsus.AutoSize = true;
            lblCusStatsus.Location = new Point(25, 118);
            lblCusStatsus.Name = "lblCusStatsus";
            lblCusStatsus.Size = new Size(114, 20);
            lblCusStatsus.TabIndex = 22;
            lblCusStatsus.Text = "Customer status";
            // 
            // txtCusName
            // 
            txtCusName.Enabled = false;
            txtCusName.Location = new Point(154, 79);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(251, 27);
            txtCusName.TabIndex = 10;
            // 
            // lblCusName
            // 
            lblCusName.AutoSize = true;
            lblCusName.Location = new Point(25, 82);
            lblCusName.Name = "lblCusName";
            lblCusName.Size = new Size(113, 20);
            lblCusName.TabIndex = 1;
            lblCusName.Text = "Customer name";
            // 
            // lblCusId
            // 
            lblCusId.AutoSize = true;
            lblCusId.Location = new Point(25, 46);
            lblCusId.Name = "lblCusId";
            lblCusId.Size = new Size(91, 20);
            lblCusId.TabIndex = 0;
            lblCusId.Text = "Customer ID";
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.AllowUserToAddRows = false;
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(468, 61);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.RowHeadersWidth = 51;
            dgvOrderDetail.RowTemplate.Height = 29;
            dgvOrderDetail.Size = new Size(1046, 310);
            dgvOrderDetail.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(468, 18);
            label1.Name = "label1";
            label1.Size = new Size(394, 38);
            label1.TabIndex = 34;
            label1.Text = "All order detail of this order:";
            // 
            // btnCreateOrderDetail
            // 
            btnCreateOrderDetail.BackColor = Color.DodgerBlue;
            btnCreateOrderDetail.ForeColor = Color.Transparent;
            btnCreateOrderDetail.Location = new Point(529, 388);
            btnCreateOrderDetail.Name = "btnCreateOrderDetail";
            btnCreateOrderDetail.Size = new Size(167, 35);
            btnCreateOrderDetail.TabIndex = 35;
            btnCreateOrderDetail.Text = "Create order detail";
            btnCreateOrderDetail.UseVisualStyleBackColor = false;
            btnCreateOrderDetail.Click += btnCreateOrderDetail_Click;
            // 
            // btnDeleteOrderDetail
            // 
            btnDeleteOrderDetail.BackColor = Color.DodgerBlue;
            btnDeleteOrderDetail.ForeColor = Color.Transparent;
            btnDeleteOrderDetail.Location = new Point(1013, 388);
            btnDeleteOrderDetail.Name = "btnDeleteOrderDetail";
            btnDeleteOrderDetail.Size = new Size(167, 35);
            btnDeleteOrderDetail.TabIndex = 36;
            btnDeleteOrderDetail.Text = "Delete order detail";
            btnDeleteOrderDetail.UseVisualStyleBackColor = false;
            btnDeleteOrderDetail.Click += btnDeleteOrderDetail_Click;
            // 
            // lblTotalOrderDetail
            // 
            lblTotalOrderDetail.AutoSize = true;
            lblTotalOrderDetail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalOrderDetail.Location = new Point(44, 278);
            lblTotalOrderDetail.Name = "lblTotalOrderDetail";
            lblTotalOrderDetail.Size = new Size(170, 28);
            lblTotalOrderDetail.TabIndex = 37;
            lblTotalOrderDetail.Text = "Total order detail: ";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPrice.Location = new Point(44, 331);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(111, 28);
            lblTotalPrice.TabIndex = 38;
            lblTotalPrice.Text = "Total price: ";
            // 
            // frmCreateOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1541, 450);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblTotalOrderDetail);
            Controls.Add(btnDeleteOrderDetail);
            Controls.Add(btnCreateOrderDetail);
            Controls.Add(label1);
            Controls.Add(btnDeleteOrder);
            Controls.Add(btnUpdateOrderDetail);
            Controls.Add(btnCreateOrder);
            Controls.Add(grbCreateOrder);
            Controls.Add(dgvOrderDetail);
            Name = "frmCreateOrder";
            Text = "Create a order";
            grbCreateOrder.ResumeLayout(false);
            grbCreateOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteOrder;
        private Button btnUpdateOrderDetail;
        private Button btnCreateOrder;
        private GroupBox grbCreateOrder;
        private Label lblBirthday;
        private DateTimePicker dtpBirthday;
        private TextBox txtStatus;
        private TextBox txtCusName;
        private Label lblCusName;
        private Label lblCusId;
        private DataGridView dgvOrderDetail;
        private TextBox txtCusStatus;
        private Label lblCusStatsus;
        private Label label1;
        private Button btnCreateOrderDetail;
        private Button btnDeleteOrderDetail;
        private Label lblTotalOrderDetail;
        private Label lblTotalPrice;
        private ComboBox cboCusId;
    }
}