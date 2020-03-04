using System;
using System.Collections.Generic;
using System.Text;

namespace CaffeManagementCore.Models.Helpers
{
    public class AddictionalCharge : BaseEntity,IAggreagateRoot
    {
        public string Name { get; set; }
        public bool isPercentage { get; set; }
        public double Charge { get; set; }
    }
}
