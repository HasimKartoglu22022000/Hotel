using FluentValidation;
using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.RoomDto;

namespace HotelProject.WebUI.ValidationRules.RoomValidationRules
{
    public class AddBookingValidator:AbstractValidator<CreateBookingDto>
    {
        public AddBookingValidator() 
        {
            RuleFor(x => x.Mail).EmailAddress().WithMessage("Geçerli Eposta adresi giriniz.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez.");
           
        }
    }
}
