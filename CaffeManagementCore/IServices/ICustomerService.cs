using CaffeManagementCore.Models;
using CaffeManagementCore.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaffeManagementCore.IServices
{
    public interface ICustomerService : ICaffeService<Customer>
    {
        Location GetAddress(Customer customer);
    }
}
