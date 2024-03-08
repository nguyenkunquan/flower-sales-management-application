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
    public partial class frmManageOrder : Form
    {
        IOrderRepository repository = new OrderRepository();
        public frmManageOrder()
        {
            InitializeComponent();
        }

        private void frmManagerOrder_Load(object sender, EventArgs e)
        {
            LoadAllOrder();
        }

        public void LoadAllOrder()
        {
            try
            {
                var orderList = repository.GetAllOrders();
                if (orderList.Count == 0) { btnModify.Visible = false; } else { btnModify.Visible = true; };
                lbl1.Text = "System was having " + orderList.Count.ToString() + " orders in history";
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = orderList;
                dgvOrder.DataSource = null;
                dgvOrder.DataSource = bindingSource;
                //dgvOrder.Columns["CustomerId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of orders");
            }
        }

        private void dgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrder.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dgvOrder.CurrentRow;
                //DataGridViewCell totalCell = selectedRow.Cells["OrderId"];
                //decimal totalValue = Convert.ToDecimal(totalCell.Value);
                //MessageBox.Show("Total value: " + totalValue.ToString());
                DataGridViewCell valueCell = selectedRow.Cells["OrderId"];
                int orderId = Convert.ToInt32(valueCell.Value);
                frmManageOrderDetail frmManageOrderDetail = new frmManageOrderDetail(orderId, this);
                frmManageOrderDetail.ShowDialog();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgvOrder.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dgvOrder.CurrentRow;
                //DataGridViewCell totalCell = selectedRow.Cells["OrderId"];
                //decimal totalValue = Convert.ToDecimal(totalCell.Value);
                //MessageBox.Show("Total value: " + totalValue.ToString());
                DataGridViewCell valueCell = selectedRow.Cells["OrderId"];
                int orderId = Convert.ToInt32(valueCell.Value);
                frmModifyOrder frmModifyOrder = new frmModifyOrder(orderId, this);
                frmModifyOrder.ShowDialog();
            }
        }

    }
}
