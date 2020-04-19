using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CaffeManagementCore.Models.Helpers
{
    public class Location : BaseEntity,IAggreagateRoot
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Landmarks { get; set; }
    }
}
