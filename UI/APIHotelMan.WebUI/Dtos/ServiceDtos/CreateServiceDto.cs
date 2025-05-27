using System.ComponentModel.DataAnnotations;

namespace APIHotelMan.WebUI.Dtos.ServiceDtos
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Hizmet ikonu boş geçilemez!")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Başlık boş geçilemez!")]
        [MaxLength(75, ErrorMessage = "Başlık en fazla 75 karakter içerebilir!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Açıklama boş geçilemez!")]
        [MaxLength(500, ErrorMessage = "Açıklama en fazla 500 karakter içerebilir!")]
        public string Description { get; set; }
    }
}
