using Entities.DTOs;
using FluentValidation;

namespace Bussines.ValidationRules.FluentValidation
{
    public class CarDtoValidator : AbstractValidator<CarDto>
    {
        public CarDtoValidator()
        {
            RuleFor(ca => ca.CarName).NotEmpty().WithMessage("Boş geçilmez");
            RuleFor(ca => ca.CarName).MinimumLength(2).WithMessage("2 den uzun olmalı");

            RuleFor(ca => ca.ModelYear).NotEmpty();
            RuleFor(ca => ca.ModelYear).GreaterThan(1986).WithMessage("Yanlış yıl girildi 86 den büyük olmalı"); ;
            RuleFor(ca => ca.ModelYear).LessThanOrEqualTo(DateTime.Now.Year).WithMessage("Yanlış yıl girildi 25 den ufak olmalı");

            RuleFor(ca => ca.DailyPrice).NotEmpty();
            RuleFor(ca => ca.DailyPrice).GreaterThan(2).WithMessage("günlük tutar 2 den az olmaz");

            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.ColorId).NotEmpty();

        }
    }
}
