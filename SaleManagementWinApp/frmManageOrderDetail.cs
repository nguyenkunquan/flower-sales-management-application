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
    public partial class frmManageOrderDetail : Form
    {
        private IOrderDetailRepository repository = new OrderDetailRepository();
        private List<OrderDetailDTO> orderDetailDTOs;
        private int orderId;
        private IFlowerBouquetRepository flowerBouquetRepository = new FlowerBouquetRepository();
        private IOrderRepository orderRepository = new OrderRepository();
        private frmManageOrder parentForm;
        private List<(int FlowerBouquetId, int Quantity)> orderDetailQuantity = new List<(int, int)>();
        public frmManageOrderDetail(int orderId, frmManageOrder frmManageOrder)
        {
            InitializeComponent();
            this.orderId = orderId;
            orderDetailDTOs = repository.GetOrderDetailByOrderId(orderId);
            LoadOrderDetailList(orderId);
            getOrderDetailQuantityBeforeSubmit();
            this.parentForm = frmManageOrder;
        }
        private void LoadOrderDetailList(int orderId)
        {
            try
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = orderDetailDTOs;

                dgvOrderDetail.DataSource = null;
                dgvOrderDetail.DataSource = bindingSource;
                lblTitle.Text = "Order details of your order with ID: " + orderId;
                IsDeal(orderId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of order detail");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmMCreateOrderDetail frmMCreateOrderDetail = new frmMCreateOrderDetail(this);
            frmMCreateOrderDetail.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                // Lấy chỉ mục của hàng được chọn
                int rowIndex = dgvOrderDetail.SelectedRows[0].Index;

                // Lấy OrderDetailDTO tương ứng với hàng được chọn
                OrderDetailDTO selectedOrderDetail = orderDetailDTOs[rowIndex];

                // Truyền selectedOrderDetail vào form mới
                frmMUpdateOrderDetail frmMUpdateOrderDetail = new frmMUpdateOrderDetail(this, selectedOrderDetail);
                frmMUpdateOrderDetail.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool CheckDuplicatedProduct(OrderDetailDTO orderDetailDTO)
        {
            foreach (var o in orderDetailDTOs)
            {
                if (o.FlowerBouquetId == orderDetailDTO.FlowerBouquetId) return false;
            }
            return true;
        }

        public void AddDataGridView(OrderDetailDTO orderDetailDTO)
        {
            orderDetailDTOs.Add(orderDetailDTO);
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            try
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = orderDetailDTOs;

                dgvOrderDetail.DataSource = null;
                dgvOrderDetail.DataSource = bindingSource;
                dgvOrderDetail.Columns["OrderDate"].Visible = false;
                dgvOrderDetail.Columns["ShippedDate"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of order detail");
            }
        }

        public void UpdateDataGridView()
        {
            LoadDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                // Lấy chỉ mục của hàng được chọn
                int rowIndex = dgvOrderDetail.SelectedRows[0].Index;

                // Lấy OrderDetailDTO tương ứng với hàng được chọn
                OrderDetailDTO selectedOrderDetail = orderDetailDTOs[rowIndex];
                orderDetailDTOs.Remove(selectedOrderDetail);
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitOrderDetail();
        }
        
        private void SubmitOrderDetail()
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();

            // Lấy danh sách chi tiết đơn hàng
            foreach (var orderDetailDTO in orderDetailDTOs)
            {
                FlowerBouquet flowerBouquet = flowerBouquetRepository.GetFlowerBouquetById(orderDetailDTO.FlowerBouquetId);
                OrderDetail orderDetail = new OrderDetail()
                {
                    OrderId = this.orderId,
                    FlowerBouquetId = orderDetailDTO.FlowerBouquetId,
                    UnitPrice = orderDetailDTO.UnitPrice,
                    Quantity = orderDetailDTO.Quantity,
                    Discount = orderDetailDTO.Discount
                };
                
                flowerBouquet.UnitsInStock = flowerBouquet.UnitsInStock + curQuantity(flowerBouquet.FlowerBouquetId) - orderDetailDTO.Quantity;
                flowerBouquetRepository.UpdateFlowerBouquet(flowerBouquet);
                orderDetails.Add(orderDetail);
            }

            // Lấy đơn hàng hiện có từ cơ sở dữ liệu
            Order order = orderRepository.GetOrderById(this.orderId);
            orderRepository.RemoveOrderDetailByOrderId(order.OrderId);
            order.OrderDetails.Clear();

            // Cập nhật chi tiết đơn hàng
            foreach (var orderDetail in orderDetails)
            {
                order.OrderDetails.Add(orderDetail); // Thêm chi tiết đơn hàng mới
            }

            // Tính tổng giá
            order.Total = CalculateTotalPrice();

            // Cập nhật đơn hàng trong cơ sở dữ liệu
            orderRepository.UpdateOrder(order);

            // Hiển thị thông báo
            frmNotification frmNotification = new frmNotification("Đơn hàng được cập nhật thành công!");
            frmNotification.ShowDialog();
            parentForm.LoadAllOrder();
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

        //lấy quantity hiện tại của các order detail trước khi Submit
        private void getOrderDetailQuantityBeforeSubmit()
        {
            foreach (var item in orderDetailDTOs)
            {
                orderDetailQuantity.Add((item.FlowerBouquetId, item.Quantity));
            }
        }
        private int curQuantity(int flowerBouquetId)
        {
            return orderDetailQuantity.FirstOrDefault(item => item.FlowerBouquetId == flowerBouquetId).Quantity;
        }

        private void IsDeal(int orderId)
        {
            OrderDTO orderDTO = orderRepository.GetAllOrders().FirstOrDefault(c => c.OrderId == orderId);
            if (orderDTO.OrderStatus == "Đã giao")
            {
                btnCreate.Enabled = false;
                btnCreate.BackColor = Color.Silver;
                btnUpdate.Enabled = false;
                btnUpdate.BackColor = Color.Silver;
                btnDelete.Enabled = false;
                btnDelete.BackColor = Color.Silver;
                btnSubmit.Enabled = false;
                btnSubmit.BackColor = Color.Silver;
            }
        }
    }
}
