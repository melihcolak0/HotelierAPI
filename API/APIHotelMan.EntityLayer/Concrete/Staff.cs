﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIHotelMan.EntityLayer.Concrete
{
    public class Staff
    {
        public int StaffId { get; set; }

        public string NameSurname { get; set; }

        public string Title { get; set; }

        public string SocialMedia1 { get; set; }

        public string SocialMedia2 { get; set; }

        public string SocialMedia3 { get; set; }

        public string ImageUrl { get; set; }
    }
}
