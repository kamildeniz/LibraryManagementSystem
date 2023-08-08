using LibraryManagementSystem.Core.Dtos;
using LibraryManagementSystem.Entity;

namespace LibraryManagementSystem.Core.Services
{
    public interface IBookService : IService<Book>
    {
        Task<CustomResponseDto<List<BookByCategoryDto>>> GetBooksByCategory();
        Task<CustomResponseDto<List<BookByAuthorDto>>> GetBooksByAuthor();
    }
}
