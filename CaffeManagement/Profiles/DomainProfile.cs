using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CaffeManagement.Models.Customer;
using CaffeManagementCore.Models;

namespace CaffeManagement.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, GetCustomerViewModel>()
                .ForMember(dest => dest.Street, 
                opt => opt.MapFrom(src => src.Address.Street))
                .ForMember(dest => dest.City,
                opt => opt.MapFrom(src => src.Address.City))
                .ForMember(dest => dest.State,
                opt => opt.MapFrom(src => src.Address.State))
                .ForMember(dest => dest.Latitude,
                opt => opt.MapFrom(src => src.Address.Latitude))
                .ForMember(dest => dest.Longitude,
                opt => opt.MapFrom(src => src.Address.Longitude))
                .ForMember(dest => dest.Landmarks,
                opt => opt.MapFrom(src => src.Address.Landmarks));

            CreateMap<CreateCustomerViewModel, Customer>()
                .ForMember(dest => dest.Address.Street,
                opt => opt.MapFrom(src => src.Street))
                .ForMember(dest => dest.Address.City,
                opt => opt.MapFrom(src => src.City))
                .ForMember(dest => dest.Address.State,
                opt => opt.MapFrom(src => src.State))
                .ForMember(dest => dest.Address.Latitude,
                opt => opt.MapFrom(src => src.Latitude))
                .ForMember(dest => dest.Address.Longitude,
                opt => opt.MapFrom(src => src.Longitude))
                .ForMember(dest => dest.Address.Landmarks,
                opt => opt.MapFrom(src => src.Landmarks));

        }
    }
}
