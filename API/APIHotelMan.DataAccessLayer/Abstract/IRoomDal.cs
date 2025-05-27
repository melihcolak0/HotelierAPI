using APIHotelMan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIHotelMan.DataAccessLayer.Abstract
{
    public interface IRoomDal : IGenericDal<Room>
    {
        public int GetRoomCount();
    }
}
