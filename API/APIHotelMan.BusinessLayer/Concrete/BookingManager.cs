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
    public class BookingManager : GenericManager<Booking>, IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal) : base(bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void TCancelBooking(int id)
        {
            _bookingDal.CancelBooking(id);
        }

        public void TConfirmBooking(int id)
        {
            _bookingDal.ConfirmBooking(id);
        }

        public int TGetBookingCount()
        {
            return _bookingDal.GetBookingCount();
        }

        public List<Booking> TGetListLast6Booking()
        {
            return _bookingDal.GetListLast6Booking();
        }

        public void TWaitBooking(int id)
        {
            _bookingDal.WaitBooking(id);
        }
    }
}
