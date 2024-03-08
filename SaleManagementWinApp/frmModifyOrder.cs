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
    public partial class frmModifyOrder : Form
    {
        private frmManageOrder frmManageOrder;
        private int orderID;
        private IOrderRepository repository = new OrderRepository();
        public frmModifyOrder(int orderId, frmManageOrder parentForm)
        {
            InitializeComponent();
            this.frmManageOrder = parentForm;
            this.orderID = orderId;
        }

        private void frmModifyOrder_Load(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void LoadOrder()
        {
            OrderDTO orderDTO = repository.GetAllOrders().FirstOrDefault(c => c.OrderId == this.orderID);
            lblTitle.Text = "Information of order ID: " + this.orderID;
            txtOrderId.Text = orderDTO.OrderId.ToString();
            txtCusName.Text = orderDTO.CustomerName;
            dtpOrderDate.Text = orderDTO.OrderDate.ToString();
            dtpShippedDate.Text = null;
            txtTotal.Text = orderDTO.Total.ToString();
            txtOrderStatus.Text = orderDTO.OrderStatus.ToString();
            IsDeal(orderDTO);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you want to deal this order?", "Deal order",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                Order order = repository.GetOrderById(this.orderID);
                order.ShippedDate = dtpShippedDate.Value;
                order.OrderStatus = "1";
                repository.UpdateOrderx(order);
                this.frmManageOrder.LoadAllOrder();
                LoadOrder();
                frmNotification frmNotification = new frmNotification("Deal this order succesfully!");
                frmNotification.ShowDialog();
            }          
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you want to remove this order?", "Remove order",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                repository.DeleteOrder(this.orderID);
                this.frmManageOrder.LoadAllOrder();
                frmNotification frmNotification = new frmNotification("Remove this order succesfully!");
                frmNotification.ShowDialog();
                this.Close();
            }
        }

        private bool CheckValidation()
        {
            if(dtpShippedDate.Value < dtpOrderDate.Value)
            {
                MessageBox.Show("Please enter a valid shipped date", "Invalid Shipped Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void dtpShippedDate_ValueChanged(object sender, EventArgs e)
        {
            if (!CheckValidation())
            {
                dtpShippedDate.Value = DateTime.Now;
                return;
            }
        }

        private void IsDeal(OrderDTO orderDTO)
        {
            if(orderDTO.OrderStatus == "Đã giao") {
                dtpShippedDate.Enabled = false;
                btnSave.BackColor = Color.Silver;
                btnSave.Enabled = false;
            }
        }
    }
}
