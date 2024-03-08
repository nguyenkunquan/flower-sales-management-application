using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class ProductDTO
    {
        public int FlowerBouquetId { get; set; }
        public int CategoryId { get; set; }
        public string FlowerBouquetName { get; set; } = null!;
        public string CategoryName { get; set; }
        public string Description { get; set; } = null!;
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public byte? FlowerBouquetStatus { get; set; }
        public string Status { get; set; }
        public int? SupplierId { get; set; }
        public string? Morphology { get; set; }
        public string SupplierName { get; set; }
    }
}
