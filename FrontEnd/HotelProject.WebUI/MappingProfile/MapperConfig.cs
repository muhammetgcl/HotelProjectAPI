using AutoMapper;
using HotelProject.Entities.Concrete;
using HotelProject.WebUI.Dtos.Register;
using HotelProject.WebUI.Dtos.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.MappingProfile
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateUserDto, AppUser>().ReverseMap();
        }
    }
}
