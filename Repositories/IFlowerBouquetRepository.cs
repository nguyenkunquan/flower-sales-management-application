using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IFlowerBouquetRepository
    {
        public List<ProductDTO> GetProductDTOs();
        public List<FlowerBouquet> GetFlowerBouquets();
        public List<Category> GetCategories();
        public List<Supplier> GetSuppliers();
        public void SaveFlowerBouquet(FlowerBouquet flowerBouquet);
        public void UpdateFlowerBouquet(FlowerBouquet flowerBouquet);
        public void DeleteFlowerBouquet(int id);
        public int GetMaxProductId();
        public FlowerBouquet GetFlowerBouquetById(int flowerBouquetId);
        public List<ProductDTO> SearchProductDTOs(string option, string keyword);
    }
}
