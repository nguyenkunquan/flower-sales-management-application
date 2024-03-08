namespace SaleManagementWinApp
{
    partial class frmModifyOrder
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
            lblOrder = new Label();
            lblCusName = new Label();
            dtpOrderDate = new DateTimePicker();
            lblOrderDate = new Label();
            lblShippedDate = new Label();
            lblTotal = new Label();
            lblOrderStatus = new Label();
            dtpShippedDate = new DateTimePicker();
            lblTitle = new Label();
            txtOrderId = new TextBox();
            txtCusName = new TextBox();
            txtTotal = new TextBox();
            txtOrderStatus = new TextBox();
            btnSave = new Button();
            btnRemove = new Button();
            SuspendLayout();
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrder.ForeColor = SystemColors.WindowFrame;
            lblOrder.Location = new Point(73, 114);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(73, 18);
            lblOrder.TabIndex = 0;
            lblOrder.Text = "Order ID:";
            // 
            // lblCusName
            // 
            lblCusName.AutoSize = true;
            lblCusName.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCusName.ForeColor = SystemColors.WindowFrame;
            lblCusName.Location = new Point(73, 160);
            lblCusName.Name = "lblCusName";
            lblCusName.Size = new Size(125, 18);
            lblCusName.TabIndex = 1;
            lblCusName.Text = "Customer Name:";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Enabled = false;
            dtpOrderDate.Location = new Point(221, 200);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(250, 27);
            dtpOrderDate.TabIndex = 2;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderDate.ForeColor = SystemColors.WindowFrame;
            lblOrderDate.Location = new Point(73, 207);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(91, 18);
            lblOrderDate.TabIndex = 3;
            lblOrderDate.Text = "Order Date:";
            // 
            // lblShippedDate
            // 
            lblShippedDate.AutoSize = true;
            lblShippedDate.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblShippedDate.ForeColor = SystemColors.WindowFrame;
            lblShippedDate.Location = new Point(73, 252);
            lblShippedDate.Name = "lblShippedDate";
            lblShippedDate.Size = new Size(108, 18);
            lblShippedDate.TabIndex = 4;
            lblShippedDate.Text = "Shipped Date:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = SystemColors.WindowFrame;
            lblTotal.Location = new Point(73, 299);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(47, 18);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total:";
            // 
            // lblOrderStatus
            // 
            lblOrderStatus.AutoSize = true;
            lblOrderStatus.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderStatus.ForeColor = SystemColors.WindowFrame;
            lblOrderStatus.Location = new Point(73, 343);
            lblOrderStatus.Name = "lblOrderStatus";
            lblOrderStatus.Size = new Size(103, 18);
            lblOrderStatus.TabIndex = 6;
            lblOrderStatus.Text = "Order Status:";
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.Location = new Point(221, 252);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new Size(250, 27);
            dtpShippedDate.TabIndex = 7;
            dtpShippedDate.ValueChanged += dtpShippedDate_ValueChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.WindowFrame;
            lblTitle.Location = new Point(42, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(104, 41);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "label1";
            // 
            // txtOrderId
            // 
            txtOrderId.Enabled = false;
            txtOrderId.Location = new Point(221, 114);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(250, 27);
            txtOrderId.TabIndex = 9;
            // 
            // txtCusName
            // 
            txtCusName.Enabled = false;
            txtCusName.Location = new Point(221, 155);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(250, 27);
            txtCusName.TabIndex = 10;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(221, 294);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(250, 27);
            txtTotal.TabIndex = 11;
            // 
            // txtOrderStatus
            // 
            txtOrderStatus.Enabled = false;
            txtOrderStatus.Location = new Point(221, 338);
            txtOrderStatus.Name = "txtOrderStatus";
            txtOrderStatus.Size = new Size(250, 27);
            txtOrderStatus.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.ForeColor = Color.Transparent;
            btnSave.Location = new Point(237, 381);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 41);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.ForeColor = Color.Transparent;
            btnRemove.Location = new Point(361, 381);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 41);
            btnRemove.TabIndex = 14;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // frmModifyOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(550, 434);
            Controls.Add(btnRemove);
            Controls.Add(btnSave);
            Controls.Add(txtOrderStatus);
            Controls.Add(txtTotal);
            Controls.Add(txtCusName);
            Controls.Add(txtOrderId);
            Controls.Add(lblTitle);
            Controls.Add(dtpShippedDate);
            Controls.Add(lblOrderStatus);
            Controls.Add(lblTotal);
            Controls.Add(lblShippedDate);
            Controls.Add(lblOrderDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(lblCusName);
            Controls.Add(lblOrder);
            Name = "frmModifyOrder";
            Text = "Modify Order";
            Load += frmModifyOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrder;
        private Label lblCusName;
        private DateTimePicker dtpOrderDate;
        private Label lblOrderDate;
        private Label lblShippedDate;
        private Label lblTotal;
        private Label lblOrderStatus;
        private DateTimePicker dtpShippedDate;
        private Label lblTitle;
        private TextBox txtOrderId;
        private TextBox txtCusName;
        private TextBox txtTotal;
        private TextBox txtOrderStatus;
        private Button btnSave;
        private Button btnRemove;
    }
}