using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICustomerRepository
    {
        public List<Customer> GetCustomer();
        public Customer GetCustomerByEmailAndPassword(string email, string password);
        public Customer GetCustomerByEmail(string email);
        public void SaveCustomer(Customer customer);
        public void UpdateCustomer(Customer customer);
        public void DeleteCustomer(int id);
        public int GetMaxCustomerId();
        public Customer GetCustomerById(int id);
    }
}
