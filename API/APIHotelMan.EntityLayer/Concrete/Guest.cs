using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIHotelMan.EntityLayer.Concrete
{
    public class Guest
    {
        public int GuestId { get; set; }

        public string NameSurname { get; set; }

        public string City { get; set; }
    }
}
