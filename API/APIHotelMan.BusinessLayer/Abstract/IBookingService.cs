using APIHotelMan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIHotelMan.BusinessLayer.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        void TConfirmBooking(int id);

        void TWaitBooking(int id);

        void TCancelBooking(int id);

        public int TGetBookingCount();

        public List<Booking> TGetListLast6Booking();
    }
}
