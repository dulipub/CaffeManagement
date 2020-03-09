using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaffeManagement.Models.Customer
{
    public class CustomerIndexModel
    {
        public ICollection<GetCustomerViewModel> Customers { get; set; }
    }
}
