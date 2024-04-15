using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class UpdateGuestValidator:AbstractValidator<UpdateGuestDto>
    {
        public UpdateGuestValidator()
        {

            RuleFor(x => x.Name).NotEmpty().WithMessage("isim Alanı Boş Geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("isim Alanı Boş Geçilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage("isim Alanı Boş Geçilemez");

            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Veri Girişi Yapınız");
            RuleFor(x => x.Surname).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Veri Girişi Yapınız");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Veri Girişi Yapınız");

            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Lütfen En Fazla 20 Karakter Veri Girişi Yapınız");
            RuleFor(x => x.Surname).MaximumLength(30).WithMessage("Lütfen En Fazla 30 Karakter Veri Girişi Yapınız");
            RuleFor(x => x.City).MaximumLength(20).WithMessage("Lütfen En Fazla 20 Karakter Veri Girişi Yapınız");
        }
    }
}
