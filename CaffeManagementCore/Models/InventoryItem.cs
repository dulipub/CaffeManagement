using System;
using System.Collections.Generic;
using System.Text;

namespace CaffeManagementCore.Models
{
    public class InventoryItem : BaseEntity,IAggreagateRoot
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime Created { get; set; }

    }
}
