using System.ComponentModel.DataAnnotations;

namespace APIHotelMan.WebUI.Dtos.IdentityDtos
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "Ad boş geçilemez!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad boş geçilemez!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "E-Mail boş geçilemez!")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Resim boş geçilemez!")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrarı boş geçilemez!")]
        [Compare("Password", ErrorMessage = "Şifreler aynı değil!")]
        public string ConfirmPassword { get; set; }

        public int WorkLocationId { get; set; }
    }
}
