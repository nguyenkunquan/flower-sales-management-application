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
using System.Xml.Linq;
using BusinessObjects;
using Repositories;

namespace SaleManagementWinApp
{
    public partial class frmStatistics : Form
    {
        IOrderRepository repository = new OrderRepository();
        public frmStatistics()
        {
            InitializeComponent();
            this.MdiParent = frmAdmin.frmAdminInstance;
        }

        private void frmStatistics_Load(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            isSort();
        }

        private void isSort()
        {
            if (btnSort.Text == "Sort sales")
            {
                LoadOrderListBySort();
            }
            else
            {
                LoadOrderList();
            }
        }

        private void dtpStarDate_ValueChanged(object sender, EventArgs e)
        {
            if (btnSort.Text == "Sort sales")
            {
                LoadOrderList();
            }
            else
            {
                LoadOrderListBySort();
            }
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (btnSort.Text == "Sort sales")
            {
                LoadOrderList();
            }
            else
            {
                LoadOrderListBySort();
            }
        }

        private void LoadOrderList()
        {
            try
            {
                var orderList = repository.GetOrdersInRangeDate(dtpStarDate.Value, dtpEndDate.Value);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = orderList;
                decimal? total = 0;
                foreach (OrderDTO order in orderList)
                {
                    total += order.Total;
                }
                txtTotalPrice.Text = total.ToString();
                txtToltalOrders.Text = orderList.Count.ToString();
                dgvStatistics.DataSource = null;
                dgvStatistics.DataSource = bindingSource;
                btnSort.Text = "Sort sales";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of orders");
            }
        }

        private void LoadOrderListBySort()
        {
            try
            {
                var orderList = repository.GetOrdersInRangeDate(dtpStarDate.Value, dtpEndDate.Value)
                                          .OrderByDescending(o => o.Total).ToList();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = orderList;
                decimal? total = 0;
                foreach (OrderDTO order in orderList)
                {
                    total += order.Total;
                }
                txtTotalPrice.Text = total.ToString();
                txtToltalOrders.Text = orderList.Count.ToString();
                dgvStatistics.DataSource = null;
                dgvStatistics.DataSource = bindingSource;
                btnSort.Text = "Unsort sales";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of orders");
            }
        }

    }
}
