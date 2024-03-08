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
using System.Xml.Linq;

namespace SaleManagementWinApp
{
    public partial class frmOrderDetailHistory : Form
    {
        IOrderDetailRepository repository = new OrderDetailRepository();
        public frmOrderDetailHistory(int orderId)
        {
            InitializeComponent();
            LoadOrderDetailList(orderId);
        }

        private void LoadOrderDetailList(int orderId)
        {
            try
            {
                var orderDetailList = repository.GetOrderDetailByOrderId(orderId);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = orderDetailList;

                dgvOrderDetail.DataSource = null;
                dgvOrderDetail.DataSource = bindingSource;
                lblTitle.Text = "Order details of your order with ID: " + orderId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of order detail");
            }
        }
    }
}
