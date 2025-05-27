using APIHotelMan.EntityLayer.Concrete;
using APIHotelMan.WebUI.Dtos.AboutDtos;
using APIHotelMan.WebUI.Dtos.GuestDtos;
using APIHotelMan.WebUI.Dtos.IdentityDtos;
using APIHotelMan.WebUI.Dtos.RoomDtos;
using APIHotelMan.WebUI.Dtos.ServiceDtos;
using APIHotelMan.WebUI.Dtos.StaffDtos;
using APIHotelMan.WebUI.Dtos.SubscribeDtos;
using APIHotelMan.WebUI.Dtos.TestimonialDtos;
using AutoMapper;

namespace APIHotelMan.WebUI.Mapping
{
    public class AutoMappingConfig : Profile
    {
        public AutoMappingConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();

            CreateMap<RegisterDto, AppUser>().ReverseMap();
            CreateMap<LogInDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ResultRoomDto, Room>().ReverseMap();

            CreateMap<ResultStaffDto, Staff>().ReverseMap();

            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<ResultSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<UpdateSubscribeDto, Subscribe>().ReverseMap();

            CreateMap<CreateGuestDto, Guest>().ReverseMap();
        }
    }
}
