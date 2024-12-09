// src/application/validators/CVValidator.cs
using FluentValidation;
using CVManager.Application.DTOs.CV;

namespace CVManager.Application.Validators
{
    public class CVValidator : AbstractValidator<CVDto>
    {
        public CVValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.PersonalInformation.FullName).NotEmpty();
            RuleFor(x => x.PersonalInformation.Email).EmailAddress();
            RuleFor(x => x.PersonalInformation.MobileNumber).NotEmpty().Matches("^[0-9]*$");
            RuleFor(x => x.ExperienceInformation.CompanyName).NotEmpty().MaximumLength(20);
        }
    }
}
