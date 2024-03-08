using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace DataAccessObjects
{
    public class OrderDAO
    {
        public static List<OrderDTO> GetOrdersInRangeDate(DateTime startDate, DateTime endDate)
        {
            List<OrderDTO> orders = new List<OrderDTO>();
            try
            {
                using (var db = new FUFlowerBouquetManagementV4Context())
                {
                    DateTime endDateAdjusted = endDate.AddDays(1);

                    orders = db.Orders.Include(o => o.Customer)
                        .Where(o => o.OrderDate.Date >= startDate.Date && o.OrderDate.Date < endDateAdjusted.Date)
                        .Select(o => new OrderDTO
                        {
                            OrderId = o.OrderId,
                            CustomerId = o.CustomerId,
                            CustomerName = o.Customer.CustomerName,
                            OrderDate = o.OrderDate,
                            ShippedDate = o.ShippedDate,
                            Total = o.Total,
                            OrderStatus = o.OrderStatus == "1" ? "Đã giao" : "Chưa giao",                
                        })
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public static List<OrderDTO> GetOrdersByCusId(int cusId)
        {
            List<OrderDTO> orders = new List<OrderDTO>();
            try
            {
                using (var db = new FUFlowerBouquetManagementV4Context())
                {
                    orders = db.Orders.Include(o => o.Customer)
                        .Where(o => o.CustomerId == cusId)
                        .Select(o => new OrderDTO
                        {
                            OrderId = o.OrderId,
                            CustomerId = o.CustomerId,
                            CustomerName = o.Customer.CustomerName,
                            OrderDate = o.OrderDate,
                            ShippedDate = o.ShippedDate,
                            Total = o.Total,
                            OrderStatus = o.OrderStatus == "1" ? "Đã giao" : "Chưa giao",
                        })
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public static List<OrderDTO> GetAllOrders()
        {
            List<OrderDTO> orders = new List<OrderDTO>();
            try
            {
                using (var db = new FUFlowerBouquetManagementV4Context())
                {
                    orders = db.Orders.Include(o => o.Customer)
                        .Select(o => new OrderDTO
                        {
                            OrderId = o.OrderId,
                            CustomerId = o.CustomerId,
                            CustomerName = o.Customer.CustomerName,
                            OrderDate = o.OrderDate,
                            ShippedDate = o.ShippedDate,
                            Total = o.Total,
                            OrderStatus = o.OrderStatus == "1" ? "Đã giao" : "Chưa giao",
                        })
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public static int GetMaxOrderId()
        {
            List<OrderDTO> orders = new List<OrderDTO>();
            try
            {
                using (var db = new FUFlowerBouquetManagementV4Context())
                {
                    orders = db.Orders.Include(o => o.Customer)
                        .Select(o => new OrderDTO
                        {
                            OrderId = o.OrderId,
                            CustomerId = o.CustomerId,
                            CustomerName = o.Customer.CustomerName,
                            OrderDate = o.OrderDate,
                            ShippedDate = o.ShippedDate,
                            Total = o.Total,
                            OrderStatus = o.OrderStatus == "1" ? "Đã giao" : "Chưa giao",
                        })
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            if (orders == null || orders.Count == 0)
            {
                throw new ArgumentException("List of orders is null or empty.");
            }
            int maxOrderId = orders.Max(o => o.OrderId);
            return maxOrderId;
        }

        public static void SaveOrder(Order order)
        {
            try
            {
                using (var db = new FUFlowerBouquetManagementV4Context())
                {
                    db.Orders.Add(order);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void UpdateOrderx(Order order)
        {
            try
            {
                using (var db = new FUFlowerBouquetManagementV4Context())
                {
                    //// Xóa tất cả OrderDetail theo OrderId
                    //var existingOrderDetails = db.OrderDetails.Where(od => od.OrderId == order.OrderId);
                    //db.OrderDetails.RemoveRange(existingOrderDetails);
                    db.Orders.Update(order); // Cập nhật thông tin đơn hàng trong cơ sở dữ liệu
                    //db.Entry(order).CurrentValues.SetValues(order);
                    db.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                }
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new Exception("Không thể cập nhật đơn hàng: " + ex.Message);
            }
        }
        public static Order GetOrderById(int orderId)
        {
            Order order = new Order();
            try
            {
                using (var db = new FUFlowerBouquetManagementV4Context())
                {
                    order = db.Orders.Include(o => o.OrderDetails).SingleOrDefault(f => f.OrderId == orderId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return order;
        }
        public static void UpdateOrder(Order order)
        {
            using (var context = new FUFlowerBouquetManagementV4Context())
            {
                // Lấy đơn hàng hiện có từ cơ sở dữ liệu
                var existingOrder = context.Orders.FirstOrDefault(o => o.OrderId == order.OrderId);

                if (existingOrder != null)
                {
                    // Cập nhật thông tin đơn hàng
                    existingOrder.Total = order.Total;
                    existingOrder.OrderStatus = order.OrderStatus;

                    // Xóa các chi tiết đơn hàng cũ (nếu cần)
                    //existingOrder.OrderDetails.Clear();

                    // Thêm hoặc cập nhật các chi tiết đơn hàng mới
                    foreach (var orderDetail in order.OrderDetails)
                    {
                        var existingDetail = existingOrder.OrderDetails.FirstOrDefault(d => d.OrderId == orderDetail.OrderId && d.FlowerBouquetId == orderDetail.FlowerBouquetId);
                        if (existingDetail != null)
                        {
                            Debug.WriteLine("jjj");
                            // Cập nhật chi tiết đơn hàng
                            existingDetail.UnitPrice = orderDetail.UnitPrice;
                            existingDetail.Quantity = orderDetail.Quantity;
                            existingDetail.Discount = orderDetail.Discount;
                        }
                        else
                        {
                            // Thêm chi tiết đơn hàng mới
                            existingOrder.OrderDetails.Add(orderDetail);
                        }
                    }

                    // Lưu thay đổi vào cơ sở dữ liệu
                    context.SaveChanges();
                }
            }
        }

        public static void DeleteOrder(int id)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementV4Context())
                {
                    var order = context.Orders.Find(id);
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void RemoveOrderDetailByOrderId(int orderId)
        {
            try
            {
                using (var db = new FUFlowerBouquetManagementV4Context())
                {
                    // Lấy tất cả các OrderDetail có OrderId tương ứng
                    var orderDetailsToDelete = db.OrderDetails.Where(od => od.OrderId == orderId).ToList();

                    // Xóa tất cả các OrderDetail này khỏi cơ sở dữ liệu
                    db.OrderDetails.RemoveRange(orderDetailsToDelete);

                    // Lưu các thay đổi vào cơ sở dữ liệu
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ nếu có
                throw new Exception("Không thể xóa OrderDetail: " + ex.Message);
            }
        }
    }
}
