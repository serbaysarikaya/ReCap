using Entities.Concrete;
using FluentValidation;

namespace Bussines.ValidationRules.FluentValidation
{
    public class CustomerDtoValidator : AbstractValidator<Customer>
    {
        public CustomerDtoValidator()
        {

            RuleFor(c => c.CompanyName).NotEmpty();
            RuleFor(c => c.CompanyName).MinimumLength(2);


        }
    }
}
