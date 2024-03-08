using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class Supplier
    {
        public Supplier()
        {
            FlowerBouquets = new HashSet<FlowerBouquet>();
        }

        public int SupplierId { get; set; }
        public string? SupplierName { get; set; }
        public string? SupplierAddress { get; set; }
        public string? Telephone { get; set; }

        public virtual ICollection<FlowerBouquet> FlowerBouquets { get; set; }
    }
}
