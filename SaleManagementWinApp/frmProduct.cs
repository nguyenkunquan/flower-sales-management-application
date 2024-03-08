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
using BusinessObjects;
using Repositories;

namespace SaleManagementWinApp
{
    public partial class frmProduct : Form
    {
        IFlowerBouquetRepository repository = new FlowerBouquetRepository();
        public frmProduct()
        {
            InitializeComponent();
            this.MdiParent = frmAdmin.frmAdminInstance;
        }
        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadCategoryList();
            LoadSupplierList();
            LoadProductList();
            LoadOptionSearch();
        }

        public void LoadCategoryList()
        {
            try
            {
                var categoryList = repository.GetCategories();
                cboCategory.DataSource = categoryList;
                cboCategory.DisplayMember = "CategoryName";
                cboCategory.ValueMember = "CategoryId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of categories");
            }
        }

        public void LoadSupplierList()
        {
            try
            {
                var supplierList = repository.GetSuppliers();
                cboSupplier.DataSource = supplierList;
                cboSupplier.DisplayMember = "SupplierName";
                cboSupplier.ValueMember = "SupplierId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of suppliers");
            }
        }

        public void LoadProductList()
        {
            try
            {
                var productList = repository.GetProductDTOs();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = productList;

                DataBindingsClear();

                txtProId.DataBindings.Add("Text", bindingSource, "FlowerBouquetId");
                txtProName.DataBindings.Add("Text", bindingSource, "FlowerBouquetName");
                cboCategory.DataBindings.Add("Text", bindingSource, "CategoryName");
                txtDes.DataBindings.Add("Text", bindingSource, "Description");
                txtUnitPrice.DataBindings.Add("Text", bindingSource, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", bindingSource, "UnitsInStock");
                txtStatus.DataBindings.Add("Text", bindingSource, "Status");
                cboSupplier.DataBindings.Add("Text", bindingSource, "SupplierName");
                txtMor.DataBindings.Add("Text", bindingSource, "Morphology");

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = bindingSource;
                dgvProducts.Columns["CategoryId"].Visible = false;
                dgvProducts.Columns["SupplierId"].Visible = false;
                dgvProducts.Columns["FlowerBouquetStatus"].Visible = false;
                //dgvProducts.Columns["Category"].DataPropertyName = "Category.CategoryName";
                //dgvProducts.Columns["Supplier"].DataPropertyName = "Supplier.SupplierName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of products");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (btnCreate.Text == "Create")
            {
                btnCreate.Text = "Cancel";
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                DataBindingsClear();
                dgvProducts.ClearSelection();
                ClearText();
            }
            else
            {
                btnCreate.Text = "Create";
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                SearchProduct();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckInputAllField() == false)
            {
                MessageBox.Show("All fields are required!", "Product Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!CheckValidNumberInput())
            {
                SearchProduct();
            }
            else
            {
                FlowerBouquet flowerBouquet = getProductByFrom();
                flowerBouquet.FlowerBouquetId = repository.GetMaxProductId() + 1;
                repository.SaveFlowerBouquet(flowerBouquet);
                btnCreate.Text = "Create";
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                SearchProduct();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckInputAllField() == false)
            {
                MessageBox.Show("All fields are required!", "Product Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!CheckValidNumberInput())
            {
                SearchProduct();
            }
            else
            {
                var flowerBouquet = getProductByFrom();
                flowerBouquet.FlowerBouquetId = int.Parse(txtProId.Text);
                repository.UpdateFlowerBouquet(flowerBouquet);
                SearchProduct();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "Product Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                var productId = int.Parse(txtProId.Text);
                repository.DeleteFlowerBouquet(productId);
                SearchProduct();
            }
        }

        private bool CheckInputAllField()
        {
            if (txtProName.Text == "" || txtDes.Text == "" || txtUnitPrice.Text == ""
                || txtUnitsInStock.Text == "" || txtMor.Text == "")
            {
                return false;
            }
            else return true;
        }

        private bool CheckValidNumberInput()
        {
            // Validate Unit Price
            if (!decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice) || unitPrice <= 0)
            {
                MessageBox.Show("Unit Price must be decimal and greater than 0!");
                return false;
            }

            // Validate Units in Stock
            if (!int.TryParse(txtUnitsInStock.Text, out int unitsInStock) || unitsInStock < 0)
            {
                MessageBox.Show("Units In Stock must be integer and greater than 0!");
                return false;
            }
            return true;
        }

        private void DataBindingsClear()
        {
            txtProId.DataBindings.Clear();
            txtProName.DataBindings.Clear();
            cboCategory.DataBindings.Clear();
            txtDes.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
            txtUnitsInStock.DataBindings.Clear();
            txtStatus.DataBindings.Clear();
            cboSupplier.DataBindings.Clear();
            txtMor.DataBindings.Clear();
        }

        private void ClearText()
        {
            txtProId.Text = "";
            txtProName.Text = "";
            cboCategory.SelectedIndex = 0;
            txtDes.Text = "";
            txtUnitPrice.Text = "";
            txtUnitsInStock.Text = "";
            txtStatus.Text = "";
            cboSupplier.SelectedIndex = 0;
            txtMor.Text = "";
        }

        private FlowerBouquet getProductByFrom()
        {
            var flowerBouquet = new FlowerBouquet
            {
                //FlowerBouquetId = int.Parse(txtProId.Text),
                FlowerBouquetName = txtProName.Text,
                CategoryId = int.Parse(cboCategory.SelectedValue.ToString()),
                Description = txtDes.Text,
                UnitPrice = decimal.Parse(txtUnitPrice.Text),
                UnitsInStock = int.Parse(txtUnitsInStock.Text),
                SupplierId = int.Parse(cboSupplier.SelectedValue.ToString()),
                Morphology = txtMor.Text
            };
            if (flowerBouquet.UnitsInStock == 0)
            {
                flowerBouquet.FlowerBouquetStatus = 0;
            }
            else flowerBouquet.FlowerBouquetStatus = 1;
            return flowerBouquet;
        }

        private void LoadOptionSearch()
        {
            // Tạo danh sách các mục cho ComboBox
            string[] options = new string[]
            {
                "ID", "Name", "UnitPrice", "UnitsInStock"
            };
            cbxOption.DataSource = options;
        }

        private void cbxOption_SelectedValueChanged(object sender, EventArgs e)
        {
            SearchProduct();
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            SearchProduct();
        }

        private void SearchProduct()
        {
            try
            {
                var productList = repository.SearchProductDTOs(cbxOption.SelectedValue.ToString(), txtValue.Text);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = productList;

                DataBindingsClear();

                txtProId.DataBindings.Add("Text", bindingSource, "FlowerBouquetId");
                txtProName.DataBindings.Add("Text", bindingSource, "FlowerBouquetName");
                cboCategory.DataBindings.Add("Text", bindingSource, "CategoryName");
                txtDes.DataBindings.Add("Text", bindingSource, "Description");
                txtUnitPrice.DataBindings.Add("Text", bindingSource, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", bindingSource, "UnitsInStock");
                txtStatus.DataBindings.Add("Text", bindingSource, "Status");
                cboSupplier.DataBindings.Add("Text", bindingSource, "SupplierName");
                txtMor.DataBindings.Add("Text", bindingSource, "Morphology");

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = bindingSource;
                dgvProducts.Columns["CategoryId"].Visible = false;
                dgvProducts.Columns["SupplierId"].Visible = false;
                dgvProducts.Columns["FlowerBouquetStatus"].Visible = false;
                //dgvProducts.Columns["Category"].DataPropertyName = "Category.CategoryName";
                //dgvProducts.Columns["Supplier"].DataPropertyName = "Supplier.SupplierName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of products");
            }
        }
    }
}
