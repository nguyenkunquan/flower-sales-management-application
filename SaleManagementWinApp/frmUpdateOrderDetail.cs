using BusinessObjects;
using DataAccessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmUpdateOrderDetail : Form
    {
        IFlowerBouquetRepository repository = new FlowerBouquetRepository();
        private bool isInitializing = true;
        private frmCreateOrder _parentForm;
        private OrderDetailDTO orderDetailDTO;
        public frmUpdateOrderDetail(frmCreateOrder parentForm, OrderDetailDTO orderDetailDTO)
        {
            InitializeComponent();
            _parentForm = parentForm;    
            this.orderDetailDTO = orderDetailDTO;
            isInitializing = false; // Kết thúc quá trình khởi tạo
        }

        public void LoadProductList()
        {
            try
            {
                var productList = repository.GetProductDTOs();
                cboProId.DataSource = productList;
                cboProId.DisplayMember = "FlowerBouquetName";
                cboProId.ValueMember = "FlowerBouquetId";
                // Kiểm tra xem có phần tử nào được chọn không
                if (cboProId.SelectedIndex != -1)
                {
                    int proId = int.Parse(cboProId.SelectedValue.ToString());
                    txtUnitsInStock.Text = repository.GetProductDTOs().SingleOrDefault(p => p.FlowerBouquetId == proId).UnitsInStock.ToString();
                    txtUnitPrice.Text = repository.GetProductDTOs().SingleOrDefault(p => p.FlowerBouquetId == proId).UnitPrice.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of products");
            }
        }

        private void cboProId_SelectedValueChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;
            if (cboProId.SelectedValue == null) return;
            // Lấy đối tượng được chọn từ combo box
            ProductDTO selectedProduct = (ProductDTO)cboProId.SelectedItem;
            int proId = selectedProduct.FlowerBouquetId;
            //Debug.WriteLine("cmm" + cboProId.SelectedValue.ToString());
            txtUnitsInStock.Text = repository.GetProductDTOs().SingleOrDefault(p => p.FlowerBouquetId == proId).UnitsInStock.ToString();
            txtUnitPrice.Text = repository.GetProductDTOs().SingleOrDefault(p => p.FlowerBouquetId == proId).UnitPrice.ToString();
            //txtQuantity.Text = "";
            //txtDiscount.Text = "";
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
                if (quantity <= 0 || discount < 0 || discount > 100)
                {
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
            if (int.Parse(txtQuantity.Text) > unitsInStock || int.Parse(txtQuantity.Text) == 0) return false;
            return flag;
        }
        private OrderDetailDTO GetOrderDetailByForm()
        {
            int proId = int.Parse(cboProId.SelectedValue.ToString());
            decimal unitPrice = decimal.Parse(txtUnitPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);
            double discount = double.Parse(txtDiscount.Text);
            OrderDetailDTO check = new OrderDetailDTO() { FlowerBouquetId = proId };
            if (_parentForm.CheckDuplicatedProduct(check) == false && proId != this.orderDetailDTO.FlowerBouquetId)
            {
                MessageBox.Show("Duplicated Product!!! Just only one flower for one order detail.", "Duplicated product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            this.orderDetailDTO.FlowerBouquetId = proId;
            this.orderDetailDTO.FlowerBouquetName = cboProId.Text;
            this.orderDetailDTO.CategoryName = repository.GetProductDTOs().SingleOrDefault(c => c.FlowerBouquetId == proId).CategoryName.ToString();
            this.orderDetailDTO.SupplierName = repository.GetProductDTOs().SingleOrDefault(c => c.FlowerBouquetId == proId).SupplierName.ToString();
            this.orderDetailDTO.UnitPrice = unitPrice;
            this.orderDetailDTO.Quantity = quantity;
            this.orderDetailDTO.Discount = discount;
            this.orderDetailDTO.TotalPrice = unitPrice * quantity * (decimal)((100 - discount) / 100.0);
            return this.orderDetailDTO;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckInputAllField() == false)
            {
                MessageBox.Show("All fields are required!", "Login",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Validation() == false) return;
            if (CheckUnitsInStock() == false)
            {
                if (int.Parse(txtQuantity.Text) == 0) MessageBox.Show("Quantity must be more than 0. Please update quantity.", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else MessageBox.Show("Not enought units in stock. Please update quantity.", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            GetOrderDetailByForm();
            _parentForm.UpdateDataGridView();
        }

        private void frmUpdateOrderDetail_Load(object sender, EventArgs e)
        {
            LoadProductList();
            // Thiết lập giá trị cho các điều khiển từ orderDetailDTO
            // Chỉ gán giá trị cho SelectedValue sau khi DataSource đã được thiết lập
            if (cboProId.Items.Count > 0)
            {
                cboProId.SelectedValue = orderDetailDTO.FlowerBouquetId;
            }
            txtQuantity.Text = orderDetailDTO.Quantity.ToString();
            txtDiscount.Text = orderDetailDTO.Discount.ToString();
        }
    }
}
