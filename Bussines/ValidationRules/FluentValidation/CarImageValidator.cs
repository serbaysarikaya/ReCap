using Entities.Concrete;
using FluentValidation;

namespace Bussines.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            RuleFor(ci => ci.CarId).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(ci => ci.ImagePath).NotEmpty().WithMessage("Boş geçilemez");
        }
    }
}
