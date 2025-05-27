using APIHotelMan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIHotelMan.BusinessLayer.Abstract
{
    public interface IStaffService : IGenericService<Staff>
    {
        public int TGetStaffCount();

        public List<Staff> TGetListLast4Staff();
    }
}
