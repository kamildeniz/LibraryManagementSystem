using FluentValidation;
using LibraryManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Service.Validations
{
    public class BorrowedBookDtoValidator:AbstractValidator<BorrowedBookDto>
    {
        public BorrowedBookDtoValidator()
        {
            RuleFor(b => b.UserId)
               .GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");

            RuleFor(b => b.BookId)
                .GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");

            RuleFor(b => b.BorrowedDate)
                .NotEmpty().WithMessage("{PropertyName} is required.");

            RuleFor(b => b.Deadline)
                .NotEmpty().WithMessage("{PropertyName} is required.");

            RuleFor(b => b.GivingBack)
                .NotNull().WithMessage("{PropertyName} is required.");
        }
    }
}
