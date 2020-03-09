using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CaffeManagement.Models.Customer;
using CaffeManagementCore.Models;

namespace CaffeManagement.Profiles
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Customer, GetCustomerViewModel>();
        }
    }
}
