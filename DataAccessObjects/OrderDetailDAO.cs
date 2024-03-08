using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class OrderDetailDAO
    {
        public static List<OrderDetailDTO> GetOrderDetailByOrderId(int orderId)
        {
            List<OrderDetailDTO> orderDetails = new List<OrderDetailDTO>();
            try
            {
                using (var db = new FUFlowerBouquetManagementV4Context())
                {
                    orderDetails = db.OrderDetails
                        .Where(od => od.OrderId == orderId)
                        .Select(od => new OrderDetailDTO
                        {
                            FlowerBouquetId = od.FlowerBouquetId,
                            FlowerBouquetName = od.FlowerBouquet.FlowerBouquetName,
                            CategoryName = od.FlowerBouquet.Category.CategoryName,
                            SupplierName = od.FlowerBouquet.Supplier.SupplierName,
                            Quantity = od.Quantity,
                            UnitPrice = od.UnitPrice,
                            Discount = od.Discount,
                            OrderDate = od.Order.OrderDate,
                            ShippedDate = od.Order.ShippedDate,
                            TotalPrice = Convert.ToDecimal(od.Quantity * Convert.ToDecimal(od.UnitPrice) * Convert.ToDecimal((100 - od.Discount)) / 100)
                        })
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderDetails;
        }

    }
}
