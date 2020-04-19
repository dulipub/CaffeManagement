using CaffeManagementCore;
using CaffeManagementCore.IServices;
using CaffeManagementCore.Models;
using CaffeManagementCore.Models.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaffeManagementServices.Services
{
    public class CustomerService : ServiceBase<Customer>,ICustomerService
    {
        public CustomerService(CaffeContext context) : base(context) { }

        public override IQueryable<Customer> GetAll()
        {
            var customers = base.GetAll();
            return customers.Include(c => c.Address);
        }

        public Location GetAddress(Customer customer)
        {
            return customer.Address;
        }
    }
}
