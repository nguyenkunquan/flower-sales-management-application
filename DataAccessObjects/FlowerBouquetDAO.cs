using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class FlowerBouquetDAO
    {

        public static List<ProductDTO> GetProductDTOs()
        {
            List<ProductDTO> productDTOs = new List<ProductDTO>();
            try
            {
                using (var context = new FUFlowerBouquetManagementV4Context())
                {
                    productDTOs = context.FlowerBouquets
                        .Include(f => f.Category)
                        .Include(f => f.Supplier)
                        .Select(f => new ProductDTO
                        {
                            FlowerBouquetId = f.FlowerBouquetId,
                            CategoryId = f.CategoryId,
                            FlowerBouquetName = f.FlowerBouquetName,
                            Description = f.Description,
                            UnitPrice = f.UnitPrice,
                            UnitsInStock = f.UnitsInStock,
                            FlowerBouquetStatus = f.FlowerBouquetStatus,
                            SupplierId = f.SupplierId,
                            Morphology = f.Morphology,
                            CategoryName = f.Category.CategoryName,
                            SupplierName = f.Supplier.SupplierName,
                            Status = f.UnitsInStock == 0 ? "Hết hàng" : "Còn hàng",
                        })
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return productDTOs;
        }

        public static List<FlowerBouquet> GetFlowerBouquets()
        {
            List<FlowerBouquet> flowerBouquets = new List<FlowerBouquet>();
            try
            {
                using (var context = new FUFlowerBouquetManagementV4Context())
                {
                    flowerBouquets = context.FlowerBouquets
                                    .Include(f => f.Category)
                                    .Include(f => f.Supplier)
                                    .ToList();
                }
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            return flowerBouquets;
        }

        //create
        public static void SaveFlowerBouquet(FlowerBouquet flowerBouquet)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementV4Context())
                {
                    context.FlowerBouquets.Add(flowerBouquet);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateFlowerBouquet(FlowerBouquet flowerBouquet)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementV4Context())
                {
                    context.FlowerBouquets.Update(flowerBouquet);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteFlowerBouquet(int id)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementV4Context())
                {
                    var flowerBouquet = context.FlowerBouquets.Find(id);
                    context.FlowerBouquets.Remove(flowerBouquet);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static int GetMaxProductId()
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementV4Context())
                {
                    var maxId = context.FlowerBouquets.Max(p => (int?)p.FlowerBouquetId); // Lấy mã ID lớn nhất
                    if (maxId.HasValue)
                    {
                        return maxId.Value;
                    }
                    else
                    {
                        // Trường hợp không có sản phẩm nào trong cơ sở dữ liệu
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static FlowerBouquet GetFlowerBouquetById(int flowerBouquetId)
        {
            FlowerBouquet flowerBouquet;
            try
            {
                using (var context = new FUFlowerBouquetManagementV4Context())
                {
                    // Tìm FlowerBouquet theo ID
                    flowerBouquet = context.FlowerBouquets
                                        .Include(f => f.Category)
                                        .Include(f => f.Supplier)
                                        .FirstOrDefault(f => f.FlowerBouquetId == flowerBouquetId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return flowerBouquet;
        }

    }
}
