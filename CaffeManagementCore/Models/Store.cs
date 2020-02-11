using CaffeManagementCore.Models.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CaffeManagementCore.Models
{
    public class Store : BaseEntity
    {
        public string Name { get; set; }
        public Location Address { get; set; }

        public  virtual ICollection<AddictionalCharge> AddictionalCharges { get; set; }

        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}
