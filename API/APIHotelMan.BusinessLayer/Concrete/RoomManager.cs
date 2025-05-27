using APIHotelMan.BusinessLayer.Abstract;
using APIHotelMan.DataAccessLayer.Abstract;
using APIHotelMan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIHotelMan.BusinessLayer.Concrete
{
    public class RoomManager : GenericManager<Room>, IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal) : base(roomDal)
        {
            _roomDal = roomDal;
        }

        public int TGetRoomCount()
        {
            return _roomDal.GetRoomCount();
        }
    }
}
