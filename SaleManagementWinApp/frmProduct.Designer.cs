namespace SaleManagementWinApp
{
    partial class frmProduct
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
            lblProId = new Label();
            lblProName = new Label();
            lblDes = new Label();
            lblUnitPrice = new Label();
            lblUnitsInStock = new Label();
            lblStatus = new Label();
            lblCategory = new Label();
            lblMor = new Label();
            lblSupplier = new Label();
            txtProId = new TextBox();
            txtProName = new TextBox();
            txtDes = new TextBox();
            txtUnitPrice = new TextBox();
            txtUnitsInStock = new TextBox();
            txtStatus = new TextBox();
            txtMor = new TextBox();
            cboCategory = new ComboBox();
            cboSupplier = new ComboBox();
            dgvProducts = new DataGridView();
            grbPro = new GroupBox();
            btnSave = new Button();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtValue = new TextBox();
            cbxOption = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            grbPro.SuspendLayout();
            SuspendLayout();
            // 
            // lblProId
            // 
            lblProId.AutoSize = true;
            lblProId.Location = new Point(26, 27);
            lblProId.Name = "lblProId";
            lblProId.Size = new Size(79, 20);
            lblProId.TabIndex = 0;
            lblProId.Text = "Product ID";
            // 
            // lblProName
            // 
            lblProName.AutoSize = true;
            lblProName.Location = new Point(26, 61);
            lblProName.Name = "lblProName";
            lblProName.Size = new Size(101, 20);
            lblProName.TabIndex = 1;
            lblProName.Text = "Product name";
            // 
            // lblDes
            // 
            lblDes.AutoSize = true;
            lblDes.Location = new Point(26, 136);
            lblDes.Name = "lblDes";
            lblDes.Size = new Size(85, 20);
            lblDes.TabIndex = 2;
            lblDes.Text = "Description";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(26, 175);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(73, 20);
            lblUnitPrice.TabIndex = 3;
            lblUnitPrice.Text = "Unit price";
            // 
            // lblUnitsInStock
            // 
            lblUnitsInStock.AutoSize = true;
            lblUnitsInStock.Location = new Point(26, 219);
            lblUnitsInStock.Name = "lblUnitsInStock";
            lblUnitsInStock.Size = new Size(96, 20);
            lblUnitsInStock.TabIndex = 4;
            lblUnitsInStock.Text = "Units in stock";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(26, 256);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(26, 98);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 20);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Category";
            // 
            // lblMor
            // 
            lblMor.AutoSize = true;
            lblMor.Location = new Point(26, 336);
            lblMor.Name = "lblMor";
            lblMor.Size = new Size(91, 20);
            lblMor.TabIndex = 7;
            lblMor.Text = "Morphology";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(26, 295);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(64, 20);
            lblSupplier.TabIndex = 8;
            lblSupplier.Text = "Supplier";
            // 
            // txtProId
            // 
            txtProId.Enabled = false;
            txtProId.Location = new Point(165, 25);
            txtProId.Name = "txtProId";
            txtProId.Size = new Size(251, 27);
            txtProId.TabIndex = 9;
            // 
            // txtProName
            // 
            txtProName.Location = new Point(165, 61);
            txtProName.Name = "txtProName";
            txtProName.Size = new Size(251, 27);
            txtProName.TabIndex = 10;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(165, 136);
            txtDes.Multiline = true;
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(251, 27);
            txtDes.TabIndex = 11;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(165, 172);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(251, 27);
            txtUnitPrice.TabIndex = 12;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(165, 216);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(251, 27);
            txtUnitsInStock.TabIndex = 13;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(165, 253);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(251, 27);
            txtStatus.TabIndex = 14;
            // 
            // txtMor
            // 
            txtMor.Location = new Point(165, 333);
            txtMor.Name = "txtMor";
            txtMor.Size = new Size(251, 27);
            txtMor.TabIndex = 15;
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(165, 98);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(251, 28);
            cboCategory.TabIndex = 16;
            // 
            // cboSupplier
            // 
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(166, 292);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(250, 28);
            cboSupplier.TabIndex = 17;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(480, 13);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.Size = new Size(958, 372);
            dgvProducts.TabIndex = 18;
            // 
            // grbPro
            // 
            grbPro.BackColor = Color.DarkCyan;
            grbPro.Controls.Add(cboSupplier);
            grbPro.Controls.Add(cboCategory);
            grbPro.Controls.Add(txtMor);
            grbPro.Controls.Add(txtStatus);
            grbPro.Controls.Add(txtUnitsInStock);
            grbPro.Controls.Add(txtUnitPrice);
            grbPro.Controls.Add(txtDes);
            grbPro.Controls.Add(txtProName);
            grbPro.Controls.Add(txtProId);
            grbPro.Controls.Add(lblSupplier);
            grbPro.Controls.Add(lblMor);
            grbPro.Controls.Add(lblCategory);
            grbPro.Controls.Add(lblStatus);
            grbPro.Controls.Add(lblUnitsInStock);
            grbPro.Controls.Add(lblUnitPrice);
            grbPro.Controls.Add(lblDes);
            grbPro.Controls.Add(lblProName);
            grbPro.Controls.Add(lblProId);
            grbPro.ForeColor = Color.Transparent;
            grbPro.Location = new Point(17, 13);
            grbPro.Name = "grbPro";
            grbPro.Size = new Size(434, 372);
            grbPro.TabIndex = 19;
            grbPro.TabStop = false;
            grbPro.Text = "Product information";
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(16, 412);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(126, 412);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 21;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(240, 412);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(356, 412);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(912, 412);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(163, 27);
            txtValue.TabIndex = 24;
            txtValue.TextChanged += txtValue_TextChanged;
            // 
            // cbxOption
            // 
            cbxOption.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxOption.FormattingEnabled = true;
            cbxOption.Location = new Point(686, 412);
            cbxOption.Name = "cbxOption";
            cbxOption.Size = new Size(151, 28);
            cbxOption.TabIndex = 25;
            cbxOption.SelectedValueChanged += cbxOption_SelectedValueChanged;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 468);
            Controls.Add(cbxOption);
            Controls.Add(txtValue);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(btnSave);
            Controls.Add(grbPro);
            Controls.Add(dgvProducts);
            Name = "frmProduct";
            Text = "Product Management";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            grbPro.ResumeLayout(false);
            grbPro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProId;
        private Label lblProName;
        private Label lblDes;
        private Label lblUnitPrice;
        private Label lblUnitsInStock;
        private Label lblStatus;
        private Label lblCategory;
        private Label lblMor;
        private Label lblSupplier;
        private TextBox txtProId;
        private TextBox txtProName;
        private TextBox txtDes;
        private TextBox txtUnitPrice;
        private TextBox txtUnitsInStock;
        private TextBox txtStatus;
        private TextBox txtMor;
        private ComboBox cboCategory;
        private ComboBox cboSupplier;
        private DataGridView dgvProducts;
        private GroupBox grbPro;
        private Button btnSave;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtValue;
        private ComboBox cbxOption;
    }
}