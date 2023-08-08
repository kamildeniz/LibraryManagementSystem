using FluentValidation;
using LibraryManagementSystem.Core.Dtos;

namespace LibraryManagementSystem.Service.Validations
{
    public class BookDtoValidator : AbstractValidator<BookDto>
    {
        public BookDtoValidator()
        {
            RuleFor(b => b.Name).NotNull().WithMessage("{PropertyName} is required.")
                .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(b => b.Stock).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater 0.");
            RuleFor(b => b.CategoryId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater 0.");
            RuleFor(b => b.AuthorId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater 0.");
            RuleFor(b => b.Description).NotNull().WithMessage("{PropertyName} is required.")
                .NotEmpty().WithMessage("{PropertyName} is required.");
          
        }
    }

}





