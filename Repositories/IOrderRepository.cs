using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderRepository
    {
        public List<OrderDTO> GetOrdersInRangeDate(DateTime startDate, DateTime endDate);
        public List<OrderDTO> GetOrdersByCusId(int cusId);
        public int GetMaxOrderId();
        public void SaveOrder(Order order);
        public List<OrderDTO> GetAllOrders();
        public Order GetOrderById(int orderId);
        public void UpdateOrder(Order order);
        public void UpdateOrderx(Order order);
        public void RemoveOrderDetailByOrderId(int orderId);
        public void DeleteOrder(int id);
    }
}
