using LibraryManagementSystem.Core.Repositories;
using LibraryManagementSystem.Entity;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Repository.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        private readonly AppDbContext _context;
        public BookRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        // IBookRepository arayüzünden gelen özel metotları uygulayın
        public  async Task<List<Book>> GetBooksByCategory()
        {
            return await _context.Books.Include(b=>b.Category).ToListAsync();
        }

        public async Task<List<Book>> GetBooksByAuthor()
        {
            return await _context.Books.Include(b => b.Author).ToListAsync();
        }

      
    }
}
