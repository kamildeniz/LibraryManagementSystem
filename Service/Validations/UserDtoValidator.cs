using FluentValidation;
using LibraryManagementSystem.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Service.Validations
{
    public class UserDtoValidator : AbstractValidator<UserDto>
    {
        public UserDtoValidator()
        {
            RuleFor(u => u.Name)
                .NotNull().WithMessage("{PropertyName} is required.")
                .NotEmpty().WithMessage("{PropertyName} is required.");

            RuleFor(u => u.Password)
                .NotNull().WithMessage("{PropertyName} is required.")
                .NotEmpty().WithMessage("{PropertyName} is required.");

            RuleFor(u => u.RoleId)
                .GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");

            RuleFor(u => u.ProfilePhotoPath)
                .NotEmpty().WithMessage("{PropertyName} is required.");

        }
    }
}
