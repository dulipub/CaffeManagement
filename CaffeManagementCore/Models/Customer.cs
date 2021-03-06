﻿using CaffeManagementCore.Models.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CaffeManagementCore.Models
{
    public class Customer : BaseEntity,IAggreagateRoot
    {
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created { get; set; }
        public Location Address { get; set; }
        public string ImageUrl { get; set; }
    }
}
