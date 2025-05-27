using System.ComponentModel.DataAnnotations;

namespace APIHotelMan.WebUI.Dtos.IdentityDtos
{
    public class LogInDto
    {
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        public string Password { get; set; }
    }
}
