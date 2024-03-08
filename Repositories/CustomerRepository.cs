using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public void DeleteCustomer(int id) => CustomerDAO.DeleteCustomer(id);

        public List<Customer> GetCustomer() => CustomerDAO.GetCustomers();

        public Customer GetCustomerByEmail(string email) => CustomerDAO.GetCustomerByEmail(email);

        public Customer GetCustomerByEmailAndPassword(string email, string password)
            => CustomerDAO.GetCustomerByEmailAndPassword(email, password);

        public Customer GetCustomerById(int id) => CustomerDAO.GetCustomerById(id);

        public int GetMaxCustomerId() => CustomerDAO.GetMaxCustomerId();

        public void SaveCustomer(Customer customer) => CustomerDAO.SaveCustomer(customer);

        public void UpdateCustomer(Customer customer) => CustomerDAO.UpdateCustomer(customer);
    }
}
