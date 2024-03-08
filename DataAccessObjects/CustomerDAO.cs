using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CustomerDAO
    {
        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                using (var context = new FUFlowerBouquetManagementV4Context())
                {
                    customers = context.Customers.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return customers;
        }

        public static Customer GetCustomerByEmailAndPassword(string email, string password)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementV4Context())
                {
                    return context.Customers.FirstOrDefault(c => c.Email == email && c.Password == password);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while fetching customer", ex);
            }
        }

        public static Customer GetCustomerByEmail(string email)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementV4Context())
                {
                    return context.Customers.FirstOrDefault(c => c.Email == email);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while fetching customer", ex);
            }
        }

        public static Customer GetCustomerById(int id)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementV4Context())
                {
                    return context.Customers.FirstOrDefault(c => c.CustomerId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while fetching customer", ex);
            }
        }

        //create
        public static void SaveCustomer(Customer customer)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementV4Context())
                {
                    context.Customers.Add(customer);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateCustomer(Customer customer)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementV4Context())
                {
                    context.Customers.Update(customer);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteCustomer(int id)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementV4Context())
                {
                    var customer = context.Customers.Find(id);
                    context.Customers.Remove(customer);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static int GetMaxCustomerId()
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementV4Context())
                {
                    var maxId = context.Customers.Max(p => (int?)p.CustomerId);
                    if (maxId.HasValue)
                    {
                        return maxId.Value;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
