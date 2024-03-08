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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmCreateOrder : Form
    {
        ICustomerRepository repository = new CustomerRepository();
        private bool isInitializing = true; // Biến này sẽ đánh dấu liệu form đang trong quá trình khởi tạo hay không
        private List<OrderDetailDTO> orderDetailList = new List<OrderDetailDTO>();
        IOrderRepository orderRepository = new OrderRepository();
        IFlowerBouquetRepository flowerBouquetRepository = new FlowerBouquetRepository();
        public frmCreateOrder()
        {
            InitializeComponent();
            LoadCustomerList();
            this.MdiParent = frmAdmin.frmAdminInstance;
            isInitializing = false; // Đánh dấu rằng quá trình khởi tạo đã hoàn thành
        }

        private void LoadDataGridView()
        {
            try
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = orderDetailList;

                dgvOrderDetail.DataSource = null;
                dgvOrderDetail.DataSource = bindingSource;
                dgvOrderDetail.Columns["OrderDate"].Visible = false;
                dgvOrderDetail.Columns["ShippedDate"].Visible = false;
                lblTotalOrderDetail.Text = "Total order detail: " + dgvOrderDetail.RowCount;
                lblTotalPrice.Text = "Total price: " + CalculateTotalPrice();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of order detail");
            }
        }

        private void LoadCustomerList()
        {
            try
            {
                var customerList = repository.GetCustomer();
                cboCusId.DataSource = customerList;
                cboCusId.DisplayMember = "CustomerId";
                cboCusId.ValueMember = "CustomerId";
                txtCusName.Text = repository.GetCustomerById(int.Parse(cboCusId.SelectedValue.ToString())).CustomerName;
                txtCusStatus.Text = repository.GetCustomerById(int.Parse(cboCusId.SelectedValue.ToString())).CustomerStatus.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of suppliers");
            }
        }

        private void cboCusId_SelectedValueChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;
            if (cboCusId.SelectedValue == null) return;
            txtCusName.Text = repository.GetCustomerById(int.Parse(cboCusId.SelectedValue.ToString())).CustomerName;
            txtCusStatus.Text = repository.GetCustomerById(int.Parse(cboCusId.SelectedValue.ToString())).CustomerStatus.ToString();
        }

        private void btnCreateOrderDetail_Click(object sender, EventArgs e)
        {
            cboCusId.Enabled = false;
            frmCreateOrderDetail frmCreateOrderDetail = new frmCreateOrderDetail(this);
            frmCreateOrderDetail.ShowDialog();
        }

        public void AddDataGridView(OrderDetailDTO orderDetailDTO)
        {
            orderDetailList.Add(orderDetailDTO);
            LoadDataGridView();
        }
        public void UpdateDataGridView()
        {
            LoadDataGridView();
        }

        public bool CheckDuplicatedProduct(OrderDetailDTO orderDetailDTO)
        {
            foreach (var o in orderDetailList)
            {
                if (o.FlowerBouquetId == orderDetailDTO.FlowerBouquetId) return false;
            }
            return true;
        }

        private decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (DataGridViewRow row in dgvOrderDetail.Rows)
            {
                // Kiểm tra xem hàng có tồn tại và ô trong cột TotalPrice không rỗng
                if (row != null && row.Cells["TotalPrice"].Value != null)
                {
                    // Lấy giá trị của ô trong cột TotalPrice và cộng vào tổng
                    totalPrice += Convert.ToDecimal(row.Cells["TotalPrice"].Value);
                }
            }
            return totalPrice;
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this order?", "Create order",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                Reset();
            }
        }

        private void Reset()
        {
            dgvOrderDetail.Rows.Clear();
            lblTotalPrice.Text = "Total price: ";
            lblTotalOrderDetail.Text = "Total order detail: ";
            cboCusId.Enabled = true;
        }

        private void btnUpdateOrderDetail_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                // Lấy chỉ mục của hàng được chọn
                int rowIndex = dgvOrderDetail.SelectedRows[0].Index;

                // Lấy OrderDetailDTO tương ứng với hàng được chọn
                OrderDetailDTO selectedOrderDetail = orderDetailList[rowIndex];

                // Truyền selectedOrderDetail vào form mới
                frmUpdateOrderDetail frmUpdateOrderDetail = new frmUpdateOrderDetail(this, selectedOrderDetail);
                frmUpdateOrderDetail.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteOrderDetail_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                // Lấy chỉ mục của hàng được chọn
                int rowIndex = dgvOrderDetail.SelectedRows[0].Index;

                // Lấy OrderDetailDTO tương ứng với hàng được chọn
                OrderDetailDTO selectedOrderDetail = orderDetailList[rowIndex];
                orderDetailList.Remove(selectedOrderDetail);
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if(orderDetailList.Count == 0)
            {
                MessageBox.Show("Order does not have any order detail.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            foreach (var orderDetailDTO in orderDetailList)
            {
                FlowerBouquet flowerBouquet = flowerBouquetRepository.GetFlowerBouquetById(orderDetailDTO.FlowerBouquetId);
                OrderDetail orderDetail = new OrderDetail()
                {                 
                    OrderId = orderRepository.GetMaxOrderId() + 1,
                    FlowerBouquetId = orderDetailDTO.FlowerBouquetId,
                    UnitPrice = orderDetailDTO.UnitPrice,
                    Quantity = orderDetailDTO.Quantity,
                    Discount = orderDetailDTO.Discount
                };
                flowerBouquet.UnitsInStock -= orderDetailDTO.Quantity;
                flowerBouquetRepository.UpdateFlowerBouquet(flowerBouquet);
                orderDetails.Add(orderDetail);
            }
            Order order = new Order();
            order.OrderId = orderRepository.GetMaxOrderId() + 1;
            order.CustomerId = int.Parse(cboCusId.SelectedValue.ToString());
            order.OrderDate = DateTime.Now;
            order.ShippedDate = null;
            order.Total = CalculateTotalPrice();
            order.OrderStatus = "0";
            foreach (var orderDetail in orderDetails)
            {
                order.OrderDetails.Add(orderDetail);
            }
            orderRepository.SaveOrder(order);
            frmNotification frmNotification = new frmNotification("Create a order successfully!");
            frmNotification.ShowDialog();
            Reset();
        }
    }
}
