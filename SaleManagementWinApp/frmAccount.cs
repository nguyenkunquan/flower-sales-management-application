using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmAccount : Form
    {
        public static frmAccount frmAccountInstance;
        private ICustomerRepository repository = new CustomerRepository();
        private Customer customer;
        public frmAccount(string email, string password)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            frmAccountInstance = this;
            customer = repository.GetCustomerByEmailAndPassword(email, password);
        }

        private void tsmMyProfile_Click(object sender, EventArgs e)
        {
            frmMyProfile frmMyProfile = new frmMyProfile(customer.Email, customer.Password);
            frmMyProfile.Show();
        }

        private void tsmViewOrderHistory_Click(object sender, EventArgs e)
        {
            frmOrderHistory frmOrderHistory = new frmOrderHistory(customer.CustomerId);
            frmOrderHistory.Show();
        }

        private void tsmLogout_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to log out?", "My Profile",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                this.Close();
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
            }
        }
    }
}
