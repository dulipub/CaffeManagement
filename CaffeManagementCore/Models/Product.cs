﻿using CaffeManagementCore.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaffeManagementCore.Models
{
    public class Product : BaseEntity,IAggreagateRoot
    {
        public string Name { get; set; }
        public float UnitBasePrice { get; set; }
        public ProductTypes Type { get; set; }
        public string ImageUrl { get; set; }
    }
}
