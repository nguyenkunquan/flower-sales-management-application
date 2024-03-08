namespace SaleManagementWinApp
{
    partial class frmManageOrder
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
            btnModify = new Button();
            lbl1 = new Label();
            lblTitle = new Label();
            dgvOrder = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // btnModify
            // 
            btnModify.Location = new Point(353, 439);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(197, 29);
            btnModify.TabIndex = 7;
            btnModify.Text = "Modify Order";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.ForeColor = Color.Transparent;
            lbl1.Location = new Point(35, 12);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(96, 38);
            lbl1.TabIndex = 6;
            lbl1.Text = "label1";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(69, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 20);
            lblTitle.TabIndex = 5;
            // 
            // dgvOrder
            // 
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(56, 65);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.Size = new Size(926, 359);
            dgvOrder.TabIndex = 4;
            dgvOrder.CellDoubleClick += dgvOrder_CellDoubleClick;
            // 
            // frmManageOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1021, 492);
            Controls.Add(btnModify);
            Controls.Add(lbl1);
            Controls.Add(lblTitle);
            Controls.Add(dgvOrder);
            Name = "frmManageOrder";
            Text = "Manager Orders";
            Load += frmManagerOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModify;
        private Label lbl1;
        private Label lblTitle;
        private DataGridView dgvOrder;
    }
}