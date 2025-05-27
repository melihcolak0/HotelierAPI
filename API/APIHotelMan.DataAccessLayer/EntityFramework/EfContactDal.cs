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
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        private readonly Context _context;

        public EfContactDal(Context context) : base(context)
        {
            _context = context;
        }

        public int GetContactMessagesCount()
        {
            return _context.Contacts.Count();
        }

        public List<Contact> GetListLast4ContactMessage()
        {
            return _context.Contacts.OrderByDescending(x => x.ContactId).Take(4).ToList();
        }
    }
}
