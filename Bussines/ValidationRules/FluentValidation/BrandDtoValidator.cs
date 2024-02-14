using Entities.Concrete;
using FluentValidation;

namespace Bussines.ValidationRules.FluentValidation
{
    public class BrandDtoValidator : AbstractValidator<Brand>
    {
        public BrandDtoValidator()
        {
            RuleFor(b => b.Name).NotEmpty();
            RuleFor(b => b.Name).MinimumLength(3);
        }
    }
}
