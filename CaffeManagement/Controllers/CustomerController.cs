using CaffeManagement.Models.Customer;
using CaffeManagementCore.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaffeManagement.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerService _customerservice;

        public CustomerController(ICustomerService service)
        {
            _customerservice = service;
        }

        public IActionResult Index()
        {
            var customers = _customerservice.GetAll();

            var customerList = customers.Select(
                result => new CustomerViewModel {
                    Id = result.Id,
                    Name = result.Name,
                    ContactNumber = result.ContactNumber,
                    ImageUrl = result.ImageUrl,
                    City = result.Address.City
                });

            CustomerIndexModel model = new CustomerIndexModel();
            model.Customers = customerList.ToList();

            return View(model);
        }
    }
}
