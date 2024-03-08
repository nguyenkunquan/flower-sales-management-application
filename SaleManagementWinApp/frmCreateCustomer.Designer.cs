namespace SaleManagementWinApp
{
    partial class frmCreateCustomer
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
            lblEmail = new Label();
            lblName = new Label();
            lblCity = new Label();
            lblCountry = new Label();
            lblPassword = new Label();
            dtpBirthday = new DateTimePicker();
            lblBirthday = new Label();
            lblStatus = new Label();
            txtEmail = new TextBox();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            txtName = new TextBox();
            txtPassword = new TextBox();
            btnCreate = new Button();
            cboStatus = new ComboBox();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.Transparent;
            lblEmail.Location = new Point(60, 77);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Transparent;
            lblName.Location = new Point(60, 170);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCity.ForeColor = Color.Transparent;
            lblCity.Location = new Point(60, 217);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(36, 20);
            lblCity.TabIndex = 2;
            lblCity.Text = "City";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountry.ForeColor = Color.Transparent;
            lblCountry.Location = new Point(60, 260);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(66, 20);
            lblCountry.TabIndex = 3;
            lblCountry.Text = "Country";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.Transparent;
            lblPassword.Location = new Point(60, 126);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(162, 301);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(250, 27);
            dtpBirthday.TabIndex = 5;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBirthday.ForeColor = Color.Transparent;
            lblBirthday.Location = new Point(60, 306);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(69, 20);
            lblBirthday.TabIndex = 6;
            lblBirthday.Text = "Birthday";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.Transparent;
            lblStatus.Location = new Point(60, 350);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(53, 20);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(162, 74);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(162, 257);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(250, 27);
            txtCountry.TabIndex = 11;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(162, 214);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(250, 27);
            txtCity.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.Location = new Point(162, 167);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 13;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(162, 123);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 14;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Yellow;
            btnCreate.Location = new Point(60, 393);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(352, 34);
            btnCreate.TabIndex = 15;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(162, 347);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(250, 28);
            cboStatus.TabIndex = 16;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ButtonHighlight;
            lblTitle.Location = new Point(12, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(267, 31);
            lblTitle.TabIndex = 17;
            lblTitle.Text = "Create A New Customer";
            // 
            // frmCreateCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(465, 450);
            Controls.Add(lblTitle);
            Controls.Add(cboStatus);
            Controls.Add(btnCreate);
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
            Name = "frmCreateCustomer";
            Text = "Creating Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblName;
        private Label lblCity;
        private Label lblCountry;
        private Label lblPassword;
        private DateTimePicker dtpBirthday;
        private Label lblBirthday;
        private Label lblStatus;
        private TextBox txtEmail;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtName;
        private TextBox txtPassword;
        private Button btnCreate;
        private ComboBox cboStatus;
        private Label lblTitle;
    }
}