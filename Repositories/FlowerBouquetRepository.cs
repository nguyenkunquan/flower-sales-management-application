using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class FlowerBouquetRepository : IFlowerBouquetRepository
    {
        public List<Category> GetCategories() => CategoryDAO.GetCategories();
        public List<FlowerBouquet> GetFlowerBouquets() => FlowerBouquetDAO.GetFlowerBouquets();
        public List<Supplier> GetSuppliers() => SupplierDAO.GetSuppliers();
        public void SaveFlowerBouquet(FlowerBouquet flowerBouquet) => FlowerBouquetDAO.SaveFlowerBouquet(flowerBouquet);
        public void UpdateFlowerBouquet(FlowerBouquet flowerBouquet) => FlowerBouquetDAO.UpdateFlowerBouquet(flowerBouquet);
        public void DeleteFlowerBouquet(int id) => FlowerBouquetDAO.DeleteFlowerBouquet(id);
        public List<ProductDTO> GetProductDTOs() => FlowerBouquetDAO.GetProductDTOs();
        public int GetMaxProductId() => FlowerBouquetDAO.GetMaxProductId();
        public FlowerBouquet GetFlowerBouquetById(int flowerBouquetId) => FlowerBouquetDAO.GetFlowerBouquetById(flowerBouquetId);
        public List<ProductDTO> SearchProductDTOs(string option, string keyword)
        {
            List<ProductDTO> products = GetProductDTOs();
            List<ProductDTO> results = new List<ProductDTO>();
            switch (option)
            {
                case "ID":
                    results = products.Where(p => p.FlowerBouquetId.ToString().ToLower().Contains(keyword.ToLower())).ToList();
                    break;
                case "Name":
                    results = products.Where(p => p.FlowerBouquetName.ToString().ToLower().Contains(keyword.ToLower())).ToList();
                    break;
                case "UnitPrice":
                    results = products.Where(p => p.UnitPrice.ToString().Contains(keyword)).ToList();
                    break;
                case "UnitsInStock":
                    results = products.Where(p => p.UnitsInStock.ToString().Contains(keyword)).ToList();
                    break;
                default:
                    throw new ArgumentException("Invalid option. Please choose from ID, Name, UnitPrice, or UnitsInStock.");
            }
            return results;
        }

    }
}
