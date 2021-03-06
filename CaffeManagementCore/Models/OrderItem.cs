﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaffeManagementCore.Models
{
    public class OrderItem :BaseEntity,IAggreagateRoot
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created { get; set; }

        public virtual Order Order { get; set; }
    }
}
