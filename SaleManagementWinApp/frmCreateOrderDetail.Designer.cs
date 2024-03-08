namespace SaleManagementWinApp
{
    partial class frmCreateOrderDetail
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
            grbCreateOrderDetail = new GroupBox();
            btnCreate = new Button();
            txtDiscount = new TextBox();
            lblDiscount = new Label();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            txtUnitPrice = new TextBox();
            lblUnitPrice = new Label();
            cboProId = new ComboBox();
            txtUnitsInStock = new TextBox();
            lblUnitsInStock = new Label();
            lblProductId = new Label();
            grbCreateOrderDetail.SuspendLayout();
            SuspendLayout();
            // 
            // grbCreateOrderDetail
            // 
            grbCreateOrderDetail.BackColor = Color.PaleVioletRed;
            grbCreateOrderDetail.Controls.Add(btnCreate);
            grbCreateOrderDetail.Controls.Add(txtDiscount);
            grbCreateOrderDetail.Controls.Add(lblDiscount);
            grbCreateOrderDetail.Controls.Add(txtQuantity);
            grbCreateOrderDetail.Controls.Add(lblQuantity);
            grbCreateOrderDetail.Controls.Add(txtUnitPrice);
            grbCreateOrderDetail.Controls.Add(lblUnitPrice);
            grbCreateOrderDetail.Controls.Add(cboProId);
            grbCreateOrderDetail.Controls.Add(txtUnitsInStock);
            grbCreateOrderDetail.Controls.Add(lblUnitsInStock);
            grbCreateOrderDetail.Controls.Add(lblProductId);
            grbCreateOrderDetail.ForeColor = Color.White;
            grbCreateOrderDetail.Location = new Point(21, 24);
            grbCreateOrderDetail.Name = "grbCreateOrderDetail";
            grbCreateOrderDetail.Size = new Size(434, 293);
            grbCreateOrderDetail.TabIndex = 31;
            grbCreateOrderDetail.TabStop = false;
            grbCreateOrderDetail.Text = "Order detail information";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Yellow;
            btnCreate.ForeColor = Color.Black;
            btnCreate.Location = new Point(25, 248);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(380, 29);
            btnCreate.TabIndex = 33;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(154, 202);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(251, 27);
            txtDiscount.TabIndex = 30;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(25, 205);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(67, 20);
            lblDiscount.TabIndex = 29;
            lblDiscount.Text = "Discount";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(154, 164);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(251, 27);
            txtQuantity.TabIndex = 28;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(25, 167);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(65, 20);
            lblQuantity.TabIndex = 27;
            lblQuantity.Text = "Quantity";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Enabled = false;
            txtUnitPrice.Location = new Point(154, 123);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(251, 27);
            txtUnitPrice.TabIndex = 26;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(25, 126);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(72, 20);
            lblUnitPrice.TabIndex = 25;
            lblUnitPrice.Text = "Unit Price";
            // 
            // cboProId
            // 
            cboProId.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProId.FormattingEnabled = true;
            cboProId.Location = new Point(154, 43);
            cboProId.Name = "cboProId";
            cboProId.Size = new Size(251, 28);
            cboProId.TabIndex = 24;
            cboProId.SelectedValueChanged += cboProId_SelectedValueChanged;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Enabled = false;
            txtUnitsInStock.Location = new Point(154, 86);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(251, 27);
            txtUnitsInStock.TabIndex = 23;
            // 
            // lblUnitsInStock
            // 
            lblUnitsInStock.AutoSize = true;
            lblUnitsInStock.Location = new Point(25, 89);
            lblUnitsInStock.Name = "lblUnitsInStock";
            lblUnitsInStock.Size = new Size(96, 20);
            lblUnitsInStock.TabIndex = 22;
            lblUnitsInStock.Text = "Units in stock";
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(25, 46);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(104, 20);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "Product Name";
            // 
            // frmCreateOrderDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(484, 357);
            Controls.Add(grbCreateOrderDetail);
            Name = "frmCreateOrderDetail";
            Text = "Create Order Detail";
            grbCreateOrderDetail.ResumeLayout(false);
            grbCreateOrderDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbCreateOrderDetail;
        private ComboBox cboProId;
        private TextBox txtUnitsInStock;
        private Label lblUnitsInStock;
        private Label lblProductId;
        private Label lblUnitPrice;
        private TextBox txtDiscount;
        private Label lblDiscount;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private TextBox txtUnitPrice;
        private Button btnCreate;
        private TextBox txtPrice;
        private Label lblPrice;
    }
}