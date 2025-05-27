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
    public class EfGuestDal : GenericRepository<Guest>, IGuestDal
    {
        private readonly Context _context;

        public EfGuestDal(Context context) : base(context)
        {
            _context = context;
        }

        public int GetGuestCount()
        {
            return _context.Guests.Count();
        }
    }
}
