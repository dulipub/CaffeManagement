using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CaffeeManagementAPI.Models.Customer;
using CaffeManagementCore.IServices;
using CaffeManagementCore.Models;
using CaffeManagementCore.Models.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaffeeManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerApiController : ControllerBase
    {
        private ICustomerService _customerService;

        private IMapper _mapper;

        public CustomerApiController(ICustomerService service, IMapper mapper)
        {
            _customerService = service;
            _mapper = mapper;
        }

        // GET api/values
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Get()
        {
            List<Customer> customers = _customerService.GetAll().Take(50).ToList();
            if (customers.Count == 0)
            {
                return NotFound();
            }

            return Ok(customers);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public IActionResult Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Post([FromBody] CreateCustomer createCustomer)
        {
            Customer customer = new Customer();
            Location address = new Location();

            address.Id = Guid.NewGuid();
            address.isDeleted = false;
            address.Landmarks = createCustomer.Landmarks;
            address.Latitude = createCustomer.Latitude;
            address.Longitude = createCustomer.Longitude;
            address.State = createCustomer.State;
            address.Street = createCustomer.Street;
            address.City = createCustomer.City;

            customer.Id = Guid.NewGuid();
            customer.Address = address;
            customer.ContactNumber = createCustomer.ContactNumber;
            customer.ImageUrl = createCustomer.ImageUrl;
            customer.isDeleted = false;
            customer.Name = createCustomer.Name;
            customer.Created = DateTime.Now;

            _customerService.Add(customer);

            return StatusCode(201);
        }
    }
}