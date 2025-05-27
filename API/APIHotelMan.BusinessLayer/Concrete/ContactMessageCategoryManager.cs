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
    public class ContactMessageCategoryManager : GenericManager<ContactMessageCategory>, IContactMessageCategoryService
    {
        private readonly IContactMessageCategoryDal _contactMessageCategoryDal;

        public ContactMessageCategoryManager(IContactMessageCategoryDal contactMessageCategoryDal) : base(contactMessageCategoryDal)
        {
            _contactMessageCategoryDal = contactMessageCategoryDal;
        }
    }
}
