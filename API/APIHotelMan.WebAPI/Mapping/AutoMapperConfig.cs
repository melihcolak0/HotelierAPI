using APIHotelMan.DtoLayer.DTOs.RoomDTOs;
using APIHotelMan.EntityLayer.Concrete;
using AutoMapper;

namespace APIHotelMan.WebAPI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<AddRoomDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();
        }
    }
}