using APIHotelMan.EntityLayer.Concrete;

namespace APIHotelMan.WebUI.Dtos.AppUserDtos
{
    public class ResultAppUserDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string City { get; set; }

        public string ImageUrl { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public int WorkLocationId { get; set; }

        public WorkLocation WorkLocation { get; set; }
    }
}
