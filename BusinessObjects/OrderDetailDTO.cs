using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class OrderDetailDTO
    {
        public int FlowerBouquetId { get; set; }
        public string FlowerBouquetName { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
        public string? SupplierName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public double Discount { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ShippedDate { get; set; }
    }
}
