namespace SaleManagementWinApp
{
    partial class frmCustomer
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
            dgvCustomers = new DataGridView();
            btnCreate = new Button();
            grbCus = new GroupBox();
            lblBirthday = new Label();
            dtpBirthday = new DateTimePicker();
            txtPassword = new TextBox();
            txtStatus = new TextBox();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtId = new TextBox();
            lblPassword = new Label();
            lblStatus = new Label();
            lblCountry = new Label();
            lblCity = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblId = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            grbCus.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(466, 10);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.RowTemplate.Height = 29;
            dgvCustomers.Size = new Size(764, 415);
            dgvCustomers.TabIndex = 19;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Yellow;
            btnCreate.ForeColor = Color.Black;
            btnCreate.Location = new Point(43, 396);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(110, 29);
            btnCreate.TabIndex = 26;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // grbCus
            // 
            grbCus.BackColor = Color.DarkCyan;
            grbCus.Controls.Add(lblBirthday);
            grbCus.Controls.Add(dtpBirthday);
            grbCus.Controls.Add(txtPassword);
            grbCus.Controls.Add(txtStatus);
            grbCus.Controls.Add(txtCountry);
            grbCus.Controls.Add(txtCity);
            grbCus.Controls.Add(txtName);
            grbCus.Controls.Add(txtEmail);
            grbCus.Controls.Add(txtId);
            grbCus.Controls.Add(lblPassword);
            grbCus.Controls.Add(lblStatus);
            grbCus.Controls.Add(lblCountry);
            grbCus.Controls.Add(lblCity);
            grbCus.Controls.Add(lblName);
            grbCus.Controls.Add(lblEmail);
            grbCus.Controls.Add(lblId);
            grbCus.ForeColor = Color.White;
            grbCus.Location = new Point(17, 10);
            grbCus.Name = "grbCus";
            grbCus.Size = new Size(434, 372);
            grbCus.TabIndex = 24;
            grbCus.TabStop = false;
            grbCus.Text = "Customer information";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(23, 276);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(64, 20);
            lblBirthday.TabIndex = 20;
            lblBirthday.Text = "Birthday";
            // 
            // dtpBirthday
            // 
            dtpBirthday.CustomFormat = "";
            dtpBirthday.Enabled = false;
            dtpBirthday.Location = new Point(152, 271);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(251, 27);
            dtpBirthday.TabIndex = 19;
            // 
            // txtPassword
            // 
            txtPassword.Enabled = false;
            txtPassword.Location = new Point(152, 113);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(251, 27);
            txtPassword.TabIndex = 18;
            // 
            // txtStatus
            // 
            txtStatus.Enabled = false;
            txtStatus.Location = new Point(152, 311);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(251, 27);
            txtStatus.TabIndex = 15;
            // 
            // txtCountry
            // 
            txtCountry.Enabled = false;
            txtCountry.Location = new Point(152, 227);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(251, 27);
            txtCountry.TabIndex = 13;
            // 
            // txtCity
            // 
            txtCity.Enabled = false;
            txtCity.Location = new Point(152, 187);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(251, 27);
            txtCity.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(152, 151);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(251, 27);
            txtName.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(152, 76);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(251, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(152, 40);
            txtId.Name = "txtId";
            txtId.Size = new Size(251, 27);
            txtId.TabIndex = 9;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(23, 116);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(26, 314);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(23, 230);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(60, 20);
            lblCountry.TabIndex = 4;
            lblCountry.Text = "Country";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(23, 190);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(34, 20);
            lblCity.TabIndex = 3;
            lblCity.Text = "City";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(23, 154);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(26, 79);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(23, 43);
            lblId.Name = "lblId";
            lblId.Size = new Size(91, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Customer ID";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LimeGreen;
            btnUpdate.ForeColor = Color.Transparent;
            btnUpdate.Location = new Point(182, 396);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 29);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.ForeColor = Color.Transparent;
            btnDelete.Location = new Point(323, 396);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 29);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 437);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(grbCus);
            Controls.Add(dgvCustomers);
            Name = "frmCustomer";
            Text = "Customer Management";
            Load += frmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            grbCus.ResumeLayout(false);
            grbCus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCustomers;
        private Button btnCreate;
        private GroupBox grbCus;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtId;
        private Label lblPassword;
        private Label lblStatus;
        private Label lblCountry;
        private Label lblCity;
        private Label lblName;
        private Label lblEmail;
        private Label lblId;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtPassword;
        private TextBox txtStatus;
        private DateTimePicker dtpBirthday;
        private Label lblBirthday;
    }
}