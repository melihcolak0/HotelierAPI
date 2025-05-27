using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIHotelMan.EntityLayer.Concrete
{
    public class Contact
    {
        public int ContactId { get; set; }

        public string NameSurname { get; set; }

        public string Mail { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public DateTime SendDate { get; set; }

        public int ContactMessageCategoryId { get; set; }

        public ContactMessageCategory ContactMessageCategory { get; set; }
    }
}
