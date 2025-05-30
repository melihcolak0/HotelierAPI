﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIHotelMan.EntityLayer.Concrete
{
    public class WorkLocation
    {
        public int WorkLocationId { get; set; }

        public string WorkLocationName { get; set; }

        public string WorkLocationCity { get; set; }

        public List<AppUser> AppUsers { get; set; }
    }
}
