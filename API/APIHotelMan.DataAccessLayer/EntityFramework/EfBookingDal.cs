using APIHotelMan.DataAccessLayer.Abstract;
using APIHotelMan.DataAccessLayer.Concrete;
using APIHotelMan.DataAccessLayer.Repositories;
using APIHotelMan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIHotelMan.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        private readonly Context _context;

        public EfBookingDal(Context context) : base(context)
        {
            _context = context;
        }

        public void CancelBooking(int id)
        {
            var booking = _context.Bookings.Find(id);
            booking.Status = "İptal Edildi";
            _context.SaveChanges();
        }

        public void ConfirmBooking(int id)
        {
            var booking = _context.Bookings.Find(id);
            booking.Status = "Onaylandı";
            _context.SaveChanges();
        }

        public int GetBookingCount()
        {
            return _context.Bookings.Count();
        }

        public List<Booking> GetListLast6Booking()
        {
            return _context.Bookings.OrderByDescending(x => x.BookingId).Take(6).ToList();
        }

        public void WaitBooking(int id)
        {
            var booking = _context.Bookings.Find(id);
            booking.Status = "Onay Bekliyor";
            _context.SaveChanges();
        }
    }
}
