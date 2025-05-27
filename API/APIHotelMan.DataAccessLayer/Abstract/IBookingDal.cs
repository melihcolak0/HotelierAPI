using APIHotelMan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIHotelMan.DataAccessLayer.Abstract
{
    public interface IBookingDal : IGenericDal<Booking>
    {
        void ConfirmBooking(int id);

        void WaitBooking(int id);

        void CancelBooking(int id);

        public int GetBookingCount();

        public List<Booking> GetListLast6Booking();
    }
}
