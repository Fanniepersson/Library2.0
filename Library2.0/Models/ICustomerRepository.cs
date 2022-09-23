using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library2._0.Models
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers { get; }
        IEnumerable<Customer> GetCustomerLoans { get; }
        Customer GetCustomerById(int id);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);
        void AddNewCustomer(Customer customer);
    }
}
