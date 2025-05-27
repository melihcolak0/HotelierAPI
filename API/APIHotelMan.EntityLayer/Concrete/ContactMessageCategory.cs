using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIHotelMan.EntityLayer.Concrete
{
    public class ContactMessageCategory
    {
        public int ContactMessageCategoryId { get; set; }

        public string ContactMessageCategoryName { get; set; }

        public List<Contact> Contacts { get; set; }
    }
}
