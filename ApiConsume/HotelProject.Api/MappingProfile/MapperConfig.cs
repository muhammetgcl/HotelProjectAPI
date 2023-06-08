using AutoMapper;
using HotelProject.Dto.Dto.RoomDto;
using HotelProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Api.MappingProfile
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AddRoomDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap(); 
        }

    }
}
