namespace SaleManagementWinApp
{
    partial class frmUpdateCustomer
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
            lblTitle = new Label();
            cboStatus = new ComboBox();
            btnUpdate = new Button();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblEmail = new Label();
            txtName = new TextBox();
            lblName = new Label();
            txtCity = new TextBox();
            lblCity = new Label();
            txtCountry = new TextBox();
            lblCountry = new Label();
            txtEmail = new TextBox();
            dtpBirthday = new DateTimePicker();
            lblStatus = new Label();
            lblBirthday = new Label();
            lblId = new Label();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ButtonHighlight;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(223, 31);
            lblTitle.TabIndex = 33;
            lblTitle.Text = "Update A Customer";
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(153, 371);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(250, 28);
            cboStatus.TabIndex = 32;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Location = new Point(51, 417);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(352, 34);
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.Transparent;
            lblPassword.Location = new Point(51, 150);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 20);
            lblPassword.TabIndex = 22;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(153, 147);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 30;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.Transparent;
            lblEmail.Location = new Point(51, 101);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 20);
            lblEmail.TabIndex = 18;
            lblEmail.Text = "Email";
            // 
            // txtName
            // 
            txtName.Location = new Point(153, 191);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 29;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Transparent;
            lblName.Location = new Point(51, 194);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 20);
            lblName.TabIndex = 19;
            lblName.Text = "Name";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(153, 238);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(250, 27);
            txtCity.TabIndex = 28;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCity.ForeColor = Color.Transparent;
            lblCity.Location = new Point(51, 241);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(36, 20);
            lblCity.TabIndex = 20;
            lblCity.Text = "City";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(153, 281);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(250, 27);
            txtCountry.TabIndex = 27;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountry.ForeColor = Color.Transparent;
            lblCountry.Location = new Point(51, 284);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(66, 20);
            lblCountry.TabIndex = 21;
            lblCountry.Text = "Country";
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(153, 98);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 26;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(153, 325);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(250, 27);
            dtpBirthday.TabIndex = 23;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.Transparent;
            lblStatus.Location = new Point(51, 374);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(53, 20);
            lblStatus.TabIndex = 25;
            lblStatus.Text = "Status";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBirthday.ForeColor = Color.Transparent;
            lblBirthday.Location = new Point(51, 330);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(69, 20);
            lblBirthday.TabIndex = 24;
            lblBirthday.Text = "Birthday";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.ForeColor = Color.Transparent;
            lblId.Location = new Point(51, 62);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 20);
            lblId.TabIndex = 34;
            lblId.Text = "ID";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(153, 59);
            txtId.Name = "txtId";
            txtId.Size = new Size(250, 27);
            txtId.TabIndex = 35;
            // 
            // frmUpdateCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(469, 463);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(lblTitle);
            Controls.Add(cboStatus);
            Controls.Add(btnUpdate);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtCity);
            Controls.Add(lblCity);
            Controls.Add(txtCountry);
            Controls.Add(lblCountry);
            Controls.Add(txtEmail);
            Controls.Add(dtpBirthday);
            Controls.Add(lblStatus);
            Controls.Add(lblBirthday);
            Name = "frmUpdateCustomer";
            Text = "Updating Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ComboBox cboStatus;
        private Button btnUpdate;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblEmail;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtCity;
        private Label lblCity;
        private TextBox txtCountry;
        private Label lblCountry;
        private TextBox txtEmail;
        private DateTimePicker dtpBirthday;
        private Label lblStatus;
        private Label lblBirthday;
        private Label lblId;
        private TextBox txtId;
    }
}