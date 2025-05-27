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
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        private readonly Context _context;

        public EfStaffDal(Context context) : base(context)
        {
            _context = context;
        }

        public int GetStaffCount()
        {
            return _context.Staffs.Count();
        }

        public List<Staff> GetListLast4Staff()
        {
            return _context.Staffs.OrderByDescending(x => x.StaffId).Take(4).ToList();
        }
    }
}
