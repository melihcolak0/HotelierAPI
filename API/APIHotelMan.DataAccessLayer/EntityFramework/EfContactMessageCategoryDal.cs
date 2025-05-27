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
    public class EfContactMessageCategoryDal : GenericRepository<ContactMessageCategory>, IContactMessageCategoryDal
    {
        public EfContactMessageCategoryDal(Context context) : base(context)
        {
        }
    }
}
