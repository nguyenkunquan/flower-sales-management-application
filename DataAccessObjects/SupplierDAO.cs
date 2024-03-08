using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class SupplierDAO
    {
        public static List<Supplier> GetSuppliers()
        {
			List<Supplier> suppliers = new List<Supplier>();
			try
			{
				using (var context = new FUFlowerBouquetManagementV4Context())
				{
					suppliers = context.Suppliers.ToList();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return suppliers;
        }
    }
}
