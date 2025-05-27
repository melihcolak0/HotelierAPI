using APIHotelMan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIHotelMan.DataAccessLayer.Abstract
{
    public interface IStaffDal : IGenericDal<Staff>
    {
        public int GetStaffCount();

        public List<Staff> GetListLast4Staff();
    }
}
