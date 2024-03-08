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
    public partial class frmAdmin : Form
    {
        public static frmAdmin frmAdminInstance;
        public frmAdmin()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            frmAdminInstance = this;
        }

        private void tsmCustomer_Click(object sender, EventArgs e)
        {
            bool isFormOpen = CheckOpenForm("frmCustomer");
            if (!isFormOpen)
            {
                frmCustomer frmCustomer = new frmCustomer();
                frmCustomer.Show();
            }
        }

        private void tsmProduct_Click(object sender, EventArgs e)
        {
            bool isFormOpen = CheckOpenForm("frmProduct");
            if (!isFormOpen)
            {
                frmProduct frmProduct = new frmProduct();
                frmProduct.Show();
            }
        }

        private void tsmStatistics_Click(object sender, EventArgs e)
        {
            bool isFormOpen = CheckOpenForm("frmStatistics");
            if(!isFormOpen) {
                frmStatistics frmStatistics = new frmStatistics();
                frmStatistics.Show();
            }
        }

        private void tsmLogout_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to log out?", "System Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                this.Close();
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
            }
        }

        private void tsmCreateOrder_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem form frmCreateOrder đã được mở hay chưa
            bool isFormOpen = CheckOpenForm("frmCreateOrder");
            if (!isFormOpen)
            {
                // Nếu form chưa được mở, thì mở nó
                frmCreateOrder frmCreateOrder = new frmCreateOrder();
                frmCreateOrder.Show();
            }
        }

        public bool CheckOpenForm(string nameForm)
        {
            return Application.OpenForms.Cast<Form>().Any(form => form.Name == nameForm);
        }

        private void tsmManagerOrder_Click(object sender, EventArgs e)
        {
            bool isFormOpen = CheckOpenForm("frmManageOrder");
            if(!isFormOpen)
            {
                frmManageOrder frmManageOrder = new frmManageOrder();
                frmManageOrder.Show();
            }           
        }
    }
}
