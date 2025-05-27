using System;

namespace APIHotelMan.WebUI.Dtos.ContactDtos
{
    public class CreateContactDto
    {
        public string NameSurname { get; set; }

        public string Mail { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public DateTime SendDate { get; set; }

        public int ContactMessageCategoryId { get; set; }
    }
}
