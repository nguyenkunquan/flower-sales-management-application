using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public List<OrderDTO> GetAllOrders() => OrderDAO.GetAllOrders();

        public int GetMaxOrderId() => OrderDAO.GetMaxOrderId();

        public List<OrderDTO> GetOrdersByCusId(int cusId) => OrderDAO.GetOrdersByCusId(cusId);

        public Order GetOrderById(int orderId) => OrderDAO.GetOrderById(orderId);

        public List<OrderDTO> GetOrdersInRangeDate(DateTime startDate, DateTime endDate) => OrderDAO.GetOrdersInRangeDate(startDate, endDate);

        public void RemoveOrderDetailByOrderId(int orderId) => OrderDAO.RemoveOrderDetailByOrderId(orderId);

        public void SaveOrder(Order order) => OrderDAO.SaveOrder(order);

        public void UpdateOrder(Order order) => OrderDAO.UpdateOrder(order);

        public void UpdateOrderx(Order order) => OrderDAO.UpdateOrderx(order);

        public void DeleteOrder(int id) => OrderDAO.DeleteOrder(id);
    }
}
