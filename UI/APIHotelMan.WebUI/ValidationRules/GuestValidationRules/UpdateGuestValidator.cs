using APIHotelMan.WebUI.Dtos.GuestDtos;
using FluentValidation;

namespace APIHotelMan.WebUI.ValidationRules.GuestValidationRules
{
    public class UpdateGuestValidator : AbstractValidator<UpdateGuestDto>
    {
        public UpdateGuestValidator()
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Adı ve Soyadı alanı boş geçilemez!");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir alanı boş geçilemez!");

            RuleFor(x => x.NameSurname).MinimumLength(5).WithMessage("Adı ve Soyadı alanı en az 5 karakter içermelidir!");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Şehir alanı en az 3 karakter içermelidir!");

            RuleFor(x => x.NameSurname).MaximumLength(50).WithMessage("Adı ve Soyadı alanı en fazla 50 karakter içerebilir!");
            RuleFor(x => x.City).MaximumLength(14).WithMessage("Şehir alanı en fazla 14 karakter içerebilir!");
        }
    }
}
