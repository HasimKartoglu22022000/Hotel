using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class CreateGuestValidator:AbstractValidator<CreateGuestDto>
    {
        public CreateGuestValidator() 
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soy isim alanı boş geçilemez.");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir alanı boş geçilemez.");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("En az 3 karakter giriniz.");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("En az 2 karakter giriniz.");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("En az 3 karakter giriniz.");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("En fazla 30 karakter giriniz.");
            RuleFor(x => x.Surname).MaximumLength(30).WithMessage("En fazla 30 karakter giriniz.");
            RuleFor(x => x.City).MaximumLength(30).WithMessage("En fazla 30 karakter giriniz.");
        }
    }
}
