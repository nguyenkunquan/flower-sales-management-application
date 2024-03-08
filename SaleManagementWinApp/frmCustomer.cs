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
    public partial class frmCustomer : Form
    {
        ICustomerRepository repository = new CustomerRepository();
        public frmCustomer()
        {
            InitializeComponent();
            this.MdiParent = frmAdmin.frmAdminInstance;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

        private void LoadCustomerList()
        {
            try
            {
                var customerList = repository.GetCustomer();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = customerList;

                DataBindingsClear();

                txtId.DataBindings.Add("Text", bindingSource, "CustomerId");
                txtEmail.DataBindings.Add("Text", bindingSource, "Email");
                txtPassword.DataBindings.Add("Text", bindingSource, "Password");
                txtName.DataBindings.Add("Text", bindingSource, "CustomerName");
                txtCity.DataBindings.Add("Text", bindingSource, "City");
                txtCountry.DataBindings.Add("Text", bindingSource, "Country");
                dtpBirthday.DataBindings.Add("Text", bindingSource, "Birthday");
                txtStatus.DataBindings.Add("Text", bindingSource, "CustomerStatus");

                dgvCustomers.DataSource = null;
                dgvCustomers.DataSource = bindingSource;
                dgvCustomers.Columns["Orders"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of products");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateCustomer createCustomerForm = new frmCreateCustomer(this);
            createCustomerForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateCustomer updateCustomerForm = new frmUpdateCustomer(txtEmail.Text, txtPassword.Text, this);
            updateCustomerForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "Customer Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                var customerId = int.Parse(txtId.Text);
                repository.DeleteCustomer(customerId);
                LoadCustomerList();
            }
        }

        private void DataBindingsClear()
        {
            txtId.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtCountry.DataBindings.Clear();
            txtStatus.DataBindings.Clear();
            dtpBirthday.DataBindings.Clear();
        }

        public void RefreshDataGridView()
        {
            LoadCustomerList();
        }

    }
}
