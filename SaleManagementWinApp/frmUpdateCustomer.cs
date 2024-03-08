using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmUpdateCustomer : Form
    {
        ICustomerRepository repository = new CustomerRepository();
        private frmCustomer _parentForm;
        public frmUpdateCustomer(string email, string password, frmCustomer parentForm)
        {
            InitializeComponent();
            LoadCustomer(email, password);
            LoadStatusList();
            _parentForm = parentForm;
        }

        private void LoadStatusList()
        {
            // Tạo danh sách các mục cho ComboBox
            int[] values = new int[] { 0, 1 };
            cboStatus.DataSource = values;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckInputAllField() == false)
            {
                MessageBox.Show("All fields are required!", "Updating Customer",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Validation() == false) return;
            else
            {
                Customer customer = GetCustomerByFrom();
                Debug.WriteLine(txtId.Text);
                repository.UpdateCustomer(customer);
                // Hiển thị thông báo thành công và làm mờ dần
                frmNotification notificationForm = new frmNotification("Customer updated successfully!");
                notificationForm.ShowDialog();
                LoadCustomer(customer.Email, customer.Password);
                _parentForm.RefreshDataGridView();
            }
        }


        public void LoadCustomer(string email, string password)
        {
            var customer = repository.GetCustomerByEmailAndPassword(email, password);
            txtId.Text = customer.CustomerId.ToString();
            txtEmail.Text = customer.Email;
            txtPassword.Text = customer.Password;
            txtName.Text = customer.CustomerName;
            txtCity.Text = customer.City;
            txtCountry.Text = customer.Country;
            dtpBirthday.Value = (DateTime)customer.Birthday;
            cboStatus.Text = customer.CustomerStatus.ToString();
        }

        private Customer GetCustomerByFrom()
        {
            var customer = new Customer
            {
                CustomerId = int.Parse(txtId.Text),
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                CustomerName = txtName.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                CustomerStatus = byte.Parse(cboStatus.SelectedValue.ToString())
            };
            // Lấy giá trị từ DateTimePicker
            DateTime selectedDate = dtpBirthday.Value.Date;
            // Trích xuất các thành phần ngày, tháng và năm từ giá trị đã lấy
            int day = selectedDate.Day;
            int month = selectedDate.Month;
            int year = selectedDate.Year;
            customer.Birthday = new DateTime(year, month, day);
            return customer;
        }

        private bool CheckInputAllField()
        {
            if (txtEmail.Text == "" || txtPassword.Text == "" || txtName.Text == ""
                || txtCity.Text == "" || txtCountry.Text == "")
            {
                return false;
            }
            else return true;
        }

        private bool Validation()
        {
            if (!Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z0-9._%+-]+@fuflowerbouquetsystem\.com$"))
            {
                MessageBox.Show("Invalid format email!", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
