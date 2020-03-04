using CaffeManagementCore;
using CaffeManagementCore.IServices;
using CaffeManagementCore.Models;
using CaffeManagementCore.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaffeManagementServices.Services
{
    public class CustomerService : ServiceBase<Customer>,ICustomerService
    {
        public CustomerService(CaffeContext context) : base(context) { }

        public Location GetAddress(Customer customer)
        {
            return customer.Address;
        }
    }
}
