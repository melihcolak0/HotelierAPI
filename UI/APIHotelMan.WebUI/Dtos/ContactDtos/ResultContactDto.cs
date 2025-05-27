﻿using System;

namespace APIHotelMan.WebUI.Dtos.ContactDtos
{
    public class ResultContactDto
    {
        public int ContactId { get; set; }

        public string NameSurname { get; set; }

        public string Mail { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public DateTime SendDate { get; set; }
    }
}
