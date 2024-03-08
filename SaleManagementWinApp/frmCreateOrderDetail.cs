using BusinessObjects;
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

namespace SaleManagementWinApp
{
    public partial class frmCreateOrderDetail : Form
    {
        IFlowerBouquetRepository repository = new FlowerBouquetRepository();
        private bool isInitializing = true;
        private frmCreateOrder _parentForm;
        public frmCreateOrderDetail(frmCreateOrder parentForm)
        {
            InitializeComponent();
            LoadProductList();
            isInitializing = false;
            _parentForm = parentForm;
        }

        public void LoadProductList()
        {
            try
            {
                var productList = repository.GetProductDTOs();
                cboProId.DataSource = productList;
                cboProId.DisplayMember = "FlowerBouquetName";
                cboProId.ValueMember = "FlowerBouquetId";
                int proId = int.Parse(cboProId.SelectedValue.ToString());
                txtUnitsInStock.Text = repository.GetProductDTOs().SingleOrDefault(p => p.FlowerBouquetId == proId).UnitsInStock.ToString();
                txtUnitPrice.Text = repository.GetProductDTOs().SingleOrDefault(p => p.FlowerBouquetId == proId).UnitPrice.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of products");
            }
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (CheckInputAllField() == false)
            {
                MessageBox.Show("All fields are required!", "Login",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Validation() == false) return;
            if(CheckUnitsInStock() == false)
            {
                if(int.Parse(txtQuantity.Text) == 0) MessageBox.Show("Quantity must be more than 0. Please update quantity.", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else MessageBox.Show("Not enought units in stock. Please update quantity.", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(_parentForm.CheckDuplicatedProduct(GetOrderDetailByForm()) == false)
            {
                MessageBox.Show("Duplicated Product!!! Just only one flower for one order detail.", "Duplicated product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _parentForm.AddDataGridView(GetOrderDetailByForm());
        }

        private void cboProId_SelectedValueChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;
            if (cboProId.SelectedValue == null) return;
            int proId = int.Parse(cboProId.SelectedValue.ToString());
            txtUnitsInStock.Text = repository.GetProductDTOs().SingleOrDefault(p => p.FlowerBouquetId == proId).UnitsInStock.ToString();
            txtUnitPrice.Text = repository.GetProductDTOs().SingleOrDefault(p => p.FlowerBouquetId == proId).UnitPrice.ToString();
            txtQuantity.Text = "";
            txtDiscount.Text = "";
        }

        private bool CheckInputAllField()
        {
            if (txtQuantity.Text == "" || txtDiscount.Text == "")
            {
                return false;
            }
            else return true;
        }

        private bool Validation()
        {
            bool flag = true;
            try
            {
                int quantity = int.Parse(txtQuantity.Text);
                int discount = int.Parse(txtDiscount.Text);
                if(quantity <= 0 ||  discount < 0 || discount > 100) {
                    throw new Exception("Invalid input for quantity or discount.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flag = false;
            }
            return flag;
        }

        private bool CheckUnitsInStock()
        {
            bool flag = true;
            int unitsInStock = int.Parse(txtUnitsInStock.Text.ToString());
            if (int.Parse(txtQuantity.Text) > unitsInStock || int.Parse(txtQuantity.Text)==0) return false;
            return flag;
        }

        private OrderDetailDTO GetOrderDetailByForm()
        {
            int proId = int.Parse(cboProId.SelectedValue.ToString());
            decimal unitPrice = decimal.Parse(txtUnitPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);
            double discount = double.Parse(txtDiscount.Text);
            OrderDetailDTO orderDetailDTO = new OrderDetailDTO();
            orderDetailDTO.FlowerBouquetId = proId;
            orderDetailDTO.FlowerBouquetName = cboProId.Text;
            orderDetailDTO.CategoryName = repository.GetProductDTOs().SingleOrDefault(c => c.FlowerBouquetId == proId).CategoryName.ToString();
            orderDetailDTO.SupplierName = repository.GetProductDTOs().SingleOrDefault(c => c.FlowerBouquetId == proId).SupplierName.ToString();
            orderDetailDTO.UnitPrice = unitPrice;
            orderDetailDTO.Quantity = quantity;
            orderDetailDTO.Discount = discount;
            orderDetailDTO.TotalPrice = unitPrice * quantity * (decimal)((100 - discount) / 100.0);
            return orderDetailDTO;
        }

    }
}
