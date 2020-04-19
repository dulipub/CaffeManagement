using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaffeeManagementAPI.Models.Customer
{
    public class CreateCustomer
    {
        public string Name { get; set; }

        public string ContactNumber { get; set; }

        public string ImageUrl { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public double? Longitude { get; set; }

        public double? Latitude { get; set; }

        public string Landmarks { get; set; }
    }
}
