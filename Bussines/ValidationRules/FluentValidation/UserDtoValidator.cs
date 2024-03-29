﻿namespace Bussines.ValidationRules.FluentValidation
{
    using Bussines.Constants.Messages;
    using Core.Entities.Concrete;
    using global::FluentValidation;
    using System.Linq;
    using System.Text.RegularExpressions;

    namespace Business.ValidationRules.FluentValidation
    {
        public class UserDtoValidator : AbstractValidator<User>
        {
            public UserDtoValidator()
            {
                RuleFor(u => u.FirstName).NotEmpty();
                RuleFor(u => u.FirstName).MinimumLength(2);
                RuleFor(u => u.FirstName).Must(IsLetter).WithMessage(UserMessages.FirstNameMustContainOnlyLetter);

                RuleFor(u => u.LastName).NotEmpty();
                RuleFor(u => u.LastName).MinimumLength(2);
                RuleFor(u => u.LastName).Must(IsLetter).WithMessage(UserMessages.LastNameMustContainOnlyLetter);

                RuleFor(u => u.Email).NotEmpty();
                RuleFor(u => u.Email).EmailAddress();


            }

            private bool IsContainUppercaseLetter(string arg)
            {
                return arg.Any(char.IsUpper);
            }

            private bool IsLetter(string arg)
            {
                Regex regex = new Regex(@"^[a-zA-ZğüşıöçĞÜŞİÖÇ]+$");
                return regex.IsMatch(arg);
            }

            //karakter içeriyor mu kontrol eder
            private bool IsContainLetter(string arg)
            {
                return arg.Any(char.IsLetter);
            }
            //sayı içeriyor mu kontrol eder.
            private bool IsContainDigit(string arg)
            {
                return arg.Any(char.IsDigit);
            }
            //özel karakter içeriyor mu kontrol eder
            private bool IsContainSpecialCharacter(string arg)
            {
                char[] specialCharacters = new char[] { '@', '#', '$', '!', '.', ',', '*', '-', '_', ';', '+', '-', '<', '>' };

                bool isContain = false;
                foreach (var item in specialCharacters)
                {
                    if (arg.Contains(item))
                    {
                        isContain = true;
                        break;
                    }
                };
                return isContain;
            }
        }
    }

}
