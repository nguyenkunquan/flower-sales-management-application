using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Repositories;


namespace SaleManagementWinApp
{
    public partial class frmLogin : Form
    {
        private AppConfigManager appConfigManager = new AppConfigManager();
        private ICustomerRepository customerRepository = new CustomerRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void CheckLogin(object sender, EventArgs e)
        {
            if (CheckInputAllField() == false)
            {
                MessageBox.Show("All fields are required!", "Login",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Validation() == false) return;
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            if (email == appConfigManager.Email())
            {
                if (password != appConfigManager.Password())
                {
                    MessageBox.Show("Wrong password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    frmAdmin frmAdmin = new frmAdmin();
                    frmAdmin.Show();
                    this.Hide();
                }
            }
            else if (customerRepository.GetCustomerByEmail(email) != null)
            {
                if (customerRepository.GetCustomerByEmail(email).Password != password)
                {
                    MessageBox.Show("Wrong password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    frmAccount frmAccount = new frmAccount(email, password);
                    frmAccount.Show();
                    this.Hide();
                }
            }
            else MessageBox.Show("The account does not exist!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool CheckInputAllField()
        {
            if (txtEmail.Text == "" || txtPassword.Text == "")
            {
                return false;
            }
            else return true;
        }

        private bool Validation()
        {
            if (!Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z0-9._%+-]+@fuflowerbouquetsystem\.com$")
                && !Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z0-9._%+-]+@FUFlowerStore\.com$"))
            {
                MessageBox.Show("Invalid format email!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar != '\0') // Kiểm tra xem ô mật khẩu đã được đặt ký tự ẩn chưa
            {
                txtPassword.PasswordChar = '\0'; // Nếu đã được đặt, đặt ký tự ẩn là ký tự trống
            }
            else
            {
                txtPassword.PasswordChar = '*'; // Nếu chưa được đặt, đặt ký tự ẩn là '*'
            }
        }
    }
}
