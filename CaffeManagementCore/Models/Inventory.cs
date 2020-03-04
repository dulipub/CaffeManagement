using System;
using System.Collections.Generic;
using System.Text;

namespace CaffeManagementCore.Models
{
    public class Inventory : BaseEntity,IAggreagateRoot
    {
        public string Name { get; set; }

        public Store Store { get; set; }

        public virtual ICollection<InventoryItem> StoredItems { get; set; }
    }
}
