using CaffeManagementCore.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaffeManagementCore.Models
{
    public class Order : BaseEntity
    {
        public DateTime Created { get; set; }
        public DateTime? Completed { get; set; }
        public Location DeliveryAddress { get; set; }
        public double DiscountPercentage { get; set; }
        public double ServiceCharge { get; set; }
        public double DeliveryCharge { get; set; }
        public double Tax { get; set; }
        public double FinalPrice { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<OrderItem> Items { get; set; }
    }
}
