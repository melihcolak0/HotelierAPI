﻿using System;

namespace APIHotelMan.WebUI.Dtos.BookingDtos
{
    public class ResultBookingDto
    {
        public int BookingId { get; set; }
        public string NameSurname { get; set; }
        public string Mail { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string AdultCount { get; set; }
        public string ChildCount { get; set; }
        public string RoomCount { get; set; }
        public string SpecialRequest { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
