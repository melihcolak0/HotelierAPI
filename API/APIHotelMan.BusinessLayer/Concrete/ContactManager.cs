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
    public class ContactManager : GenericManager<Contact>, IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal) : base(contactDal)
        {
            _contactDal = contactDal;
        }

        public int TGetContactMessagesCount()
        {
            return _contactDal.GetContactMessagesCount();
        }

        public List<Contact> TGetListLast4ContactMessage()
        {
            return _contactDal.GetListLast4ContactMessage();
        }
    }
}
