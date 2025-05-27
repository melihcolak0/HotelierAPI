using APIHotelMan.BusinessLayer.Abstract;
using APIHotelMan.DtoLayer.DTOs.RoomDTOs;
using APIHotelMan.EntityLayer.Concrete;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIHotelMan.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public Room2Controller(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }
        
        [HttpGet]
        public IActionResult ListRoom()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoom(AddRoomDto addRoomDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var values = _mapper.Map<Room>(addRoomDto);
            _roomService.TInsert(values);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAddRoom(UpdateRoomDto updateRoomDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var values = _mapper.Map<Room>(updateRoomDto);
            _roomService.TUpdate(values);

            return Ok();
        }
    }
}
