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
    public class StaffManager : GenericManager<Staff>, IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal) : base(staffDal)
        {
            _staffDal = staffDal;
        }

        public int TGetStaffCount()
        {
            return _staffDal.GetStaffCount();
        }

        public List<Staff> TGetListLast4Staff()
        {
            return _staffDal.GetListLast4Staff();
        }
    }
}
