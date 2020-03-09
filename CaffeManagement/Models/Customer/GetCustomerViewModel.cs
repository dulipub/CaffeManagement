﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaffeManagement.Models.Customer
{
    public class GetCustomerViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string ContactNumber { get; set; }

        public string ImageUrl { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public double? Longitude { get; set; }

        public double? Latitude { get; set; }

        public string Landmarks { get; set; }
    }
}