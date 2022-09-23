using Library2._0.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library2._0.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IBookRepository _bookRepository;
       

        public CustomerController(ICustomerRepository customerRepository, IBookRepository bookRepository)
        {
            _customerRepository = customerRepository;
            _bookRepository = bookRepository;
        }


        public IActionResult Details(int id)
        {
            IEnumerable<Customer> customers;

            customers = _customerRepository.GetCustomerLoans.Where(c => c.CustomerId == id);
            return View(customers);
        }

        public IActionResult ActiveLoans(int id)
        {
            IEnumerable<Customer> customers;

            customers = _customerRepository.GetCustomerLoans.Where(c => c.CustomerId == id);
            return View(customers);
        }

        public IActionResult GetHistoryLoans(int id)
        {
            IEnumerable<Customer> customers;

            customers = _customerRepository.GetCustomerLoans.Where(c => c.CustomerId == id);
            return View(customers);
        }





        public IActionResult Index()
        {
            IEnumerable<Customer> customers;

            customers = _customerRepository.GetAllCustomers;

            return View(customers);
        }


        public IActionResult AddOrEditCustomer(int id)
        {
            if (id == 0)
            {
                return View(new Customer());
            }
            else
            {
                return View(_customerRepository.GetCustomerById(id));
            }
            
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEditCustomer([Bind("CustomerId,FirstName,LastName,City,Address,ZipCode,PhoneNumber")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                if (customer.CustomerId == 0)
                {
                    _customerRepository.AddNewCustomer(customer);
                }
                else
                {
                    _customerRepository.UpdateCustomer(customer);
                    return RedirectToAction(nameof(Index));

                }
            }
            return View(customer);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Customer customer = _customerRepository.GetCustomerById(id);
            _customerRepository.DeleteCustomer(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
