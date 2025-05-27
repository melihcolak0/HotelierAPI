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
    public class GuestManager : GenericManager<Guest>, IGuestService
    {
        private readonly IGuestDal _guestDal;

        public GuestManager(IGuestDal guestDal) : base(guestDal)
        {
            _guestDal = guestDal;
        }

        public int TGetGuestCount()
        {
            return _guestDal.GetGuestCount();
        }
    }
}
