using AutoMapper;
using CaffeManagement.Models.Customer;
using CaffeManagementCore.IServices;
using CaffeManagementCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaffeManagement.Controllers
{
    public class CustomersController : Controller
    {
        private ICustomerService _customerservice;
        private IMapper _mapper;

        public CustomersController(ICustomerService service, IMapper mapper)
        {
            _customerservice = service;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            List<Customer> customers = _customerservice.GetAll().ToList();

            List<GetCustomerViewModel> customerList = _mapper.Map<List<GetCustomerViewModel>>(customers);

            CustomerIndexModel model = new CustomerIndexModel();
            model.Customers = customerList;

            return View(model);
        }

        public IActionResult customer(Guid id)
        {
            var customer = _customerservice.GetEntity(id);
            ViewBag.cusid = customer.Id.ToString();
            return View();
        }
    }
}
