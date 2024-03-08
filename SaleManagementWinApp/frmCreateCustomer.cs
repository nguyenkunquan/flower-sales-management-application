using BusinessObjects;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using Repositories;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Timer = System.Windows.Forms.Timer;

namespace SaleManagementWinApp
{
    public partial class frmCreateCustomer : Form
    {
        ICustomerRepository repository = new CustomerRepository();
        private frmCustomer _parentForm;
        public frmCreateCustomer(frmCustomer parentForm)
        {
            InitializeComponent();
            LoadStatusList();
            _parentForm = parentForm;
        }

        private void LoadStatusList()
        {
            // Tạo danh sách các mục cho ComboBox
            int[] values = new int[] { 0, 1 };
            cboStatus.DataSource = values;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(CheckInputAllField()==false)
            {
                MessageBox.Show("All fields are required!", "Creating Customer",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Validation() == false) return;
            if (repository.GetCustomer().Any(c => c.Email == txtEmail.Text))
            {
                MessageBox.Show("Email already exists. Please use a different email.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Customer customer = GetCustomerByFrom();
                repository.SaveCustomer(customer);
                ClearText();
                // Hiển thị thông báo thành công và làm mờ dần
                frmNotification notificationForm = new frmNotification("Customer created successfully!");
                notificationForm.ShowDialog();

                // Cập nhật DataGridView trong form cha
                _parentForm.RefreshDataGridView();
            }
        }

        private Customer GetCustomerByFrom()
        {
            var customer = new Customer
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                CustomerName = txtName.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                CustomerStatus = byte.Parse(cboStatus.SelectedValue.ToString())
            };
            customer.CustomerId = repository.GetMaxCustomerId() + 1;
            // Lấy giá trị từ DateTimePicker
            DateTime selectedDate = dtpBirthday.Value.Date;
            // Trích xuất các thành phần ngày, tháng và năm từ giá trị đã lấy
            int day = selectedDate.Day;
            int month = selectedDate.Month;
            int year = selectedDate.Year;
            customer.Birthday = new DateTime(year, month, day);
            return customer;
        }

        private void ClearText()
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtName.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            cboStatus.SelectedIndex = 0;
            dtpBirthday.Text = string.Empty;
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
            if(!Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z0-9._%+-]+@fuflowerbouquetsystem\.com$"))
            {
                MessageBox.Show("Invalid format email!", "Creating Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
