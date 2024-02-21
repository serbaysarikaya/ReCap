using Bussines.Constants.Messages;
using Entities.Concrete;
using FluentValidation;

namespace Bussines.ValidationRules.FluentValidation
{
    public class ColorDtoValidator : AbstractValidator<Color>
    {
        public ColorDtoValidator()
        {

            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).Must(ValidColorName).WithMessage(Messages.ColorNameMustContainOnlyLetter);
            RuleFor(c => c.Name).MinimumLength(2);

        }

        private bool ValidColorName(string arg)
        {
            return !arg.Any(char.IsDigit);
        }
    }
}
