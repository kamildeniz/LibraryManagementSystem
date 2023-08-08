using LibraryManagementSystem.Entity;

namespace LibraryManagementSystem.Core.Repositories
{

    public interface IBookRepository : IGenericRepository<Book>
    {
        Task<List<Book>> GetBooksByCategory();
        Task<List<Book>> GetBooksByAuthor();
    }
}
