using CaffeManagementCore;
using CaffeManagementCore.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaffeManagementServices.Services
{
    public class LocationService : ServiceBase<Location>
    {
        public  LocationService(CaffeContext context) : base(context) { }
    }
}
