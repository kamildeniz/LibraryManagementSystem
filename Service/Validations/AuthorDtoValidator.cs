using FluentValidation;
using LibraryManagementSystem.Core.Dtos;

namespace LibraryManagementSystem.Service.Validations
{
    public class AuthorDtoValidator : AbstractValidator<AuthorDto>
    {
        public AuthorDtoValidator()
        {
            RuleFor(a => a.Name).NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(a => a.SurName).NotEmpty().WithMessage("{PropertyName} is required.");
        }
    }
}
