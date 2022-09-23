using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library2._0.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly LibraryDbContext _libraryContext;

        public CustomerRepository(LibraryDbContext libraryContext)
        {
            _libraryContext = libraryContext;
        }



        public IEnumerable<Customer> GetAllCustomers
        {
            get
            {
                return _libraryContext.Customers;
            }
        }

        public IEnumerable<Customer> GetCustomerLoans
        {
            get
            {
                return _libraryContext.Customers.Include(c => c.LibraryLoans).ThenInclude(b => b.Book).ToList();
            }
        }

      


        public void AddNewCustomer(Customer customer)
        {
            _libraryContext.Customers.Add(customer);
            _libraryContext.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            Customer customer = _libraryContext.Customers.Find(id);
            _libraryContext.Customers.Remove(customer);
            _libraryContext.SaveChanges();
        }

        public Customer GetCustomerById(int id)
        {
            return _libraryContext.Customers.Include(l => l.LibraryLoans).FirstOrDefault(c => c.CustomerId == id);
        }


        public void UpdateCustomer(Customer customer)
        {
            _libraryContext.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _libraryContext.SaveChanges();
        }
    }
}
