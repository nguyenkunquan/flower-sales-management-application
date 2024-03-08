namespace SaleManagementWinApp
{
    partial class frmMyProfile
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
            lblBirthday = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ButtonHighlight;
            lblTitle.Location = new Point(18, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(225, 31);
            lblTitle.TabIndex = 51;
            lblTitle.Text = "Update Your Profile";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Location = new Point(41, 324);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(352, 34);
            btnUpdate.TabIndex = 49;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.Transparent;
            lblPassword.Location = new Point(41, 105);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 20);
            lblPassword.TabIndex = 40;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(143, 102);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 48;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.Transparent;
            lblEmail.Location = new Point(41, 56);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 20);
            lblEmail.TabIndex = 36;
            lblEmail.Text = "Email";
            // 
            // txtName
            // 
            txtName.Location = new Point(143, 146);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 47;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Transparent;
            lblName.Location = new Point(41, 149);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 20);
            lblName.TabIndex = 37;
            lblName.Text = "Name";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(143, 193);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(250, 27);
            txtCity.TabIndex = 46;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCity.ForeColor = Color.Transparent;
            lblCity.Location = new Point(41, 196);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(36, 20);
            lblCity.TabIndex = 38;
            lblCity.Text = "City";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(143, 236);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(250, 27);
            txtCountry.TabIndex = 45;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountry.ForeColor = Color.Transparent;
            lblCountry.Location = new Point(41, 239);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(66, 20);
            lblCountry.TabIndex = 39;
            lblCountry.Text = "Country";
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(143, 53);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 44;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(143, 280);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(250, 27);
            dtpBirthday.TabIndex = 41;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBirthday.ForeColor = Color.Transparent;
            lblBirthday.Location = new Point(41, 285);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(69, 20);
            lblBirthday.TabIndex = 42;
            lblBirthday.Text = "Birthday";
            // 
            // frmMyProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(451, 377);
            Controls.Add(lblTitle);
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
            Controls.Add(lblBirthday);
            Name = "frmMyProfile";
            Text = "My Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
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
        private Label lblBirthday;
    }
}