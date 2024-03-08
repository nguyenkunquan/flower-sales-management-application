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
    public partial class frmOrderHistory : Form
    {
        private int myId;
        IOrderRepository repository = new OrderRepository();

        public frmOrderHistory(int myId)
        {
            InitializeComponent();
            this.MdiParent = frmAccount.frmAccountInstance;
            this.myId = myId;
        }

        private void frmOrderHistory_Load(object sender, EventArgs e)
        {
            LoadOrderHistory();
        }

        private void LoadOrderHistory()
        {
            try
            {
                var orderList = repository.GetOrdersByCusId(myId);
                if (orderList.Count == 0) { btnView.Visible = false; } else { btnView.Visible = true; };
                lbl1.Text = "You was having " + orderList.Count.ToString() + " orders in history";
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = orderList;
                dgvOrderHistory.DataSource = null;
                dgvOrderHistory.DataSource = bindingSource;
                dgvOrderHistory.Columns["CustomerId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of orders");
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvOrderHistory.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dgvOrderHistory.CurrentRow;
                //DataGridViewCell totalCell = selectedRow.Cells["OrderId"];
                //decimal totalValue = Convert.ToDecimal(totalCell.Value);
                //MessageBox.Show("Total value: " + totalValue.ToString());
                DataGridViewCell valueCell = selectedRow.Cells["OrderId"];
                int orderId = Convert.ToInt32(valueCell.Value);
                frmOrderDetailHistory frmOrderDetailHistory = new frmOrderDetailHistory(orderId);
                frmOrderDetailHistory.ShowDialog();
            }
        }
    }
}
