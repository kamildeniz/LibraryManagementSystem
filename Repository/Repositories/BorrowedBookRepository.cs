using LibraryManagementSystem.Core.Repositories;
using LibraryManagementSystem.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Repository.Repositories
{
    public class BorrowedBookRepository : GenericRepository<BorrowedBook>, IBorrowedRepository
    {
        private readonly AppDbContext _context;
        public BorrowedBookRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        // IBookRepository arayüzünden gelen özel metotları uygulayın
        public async Task<List<BorrowedBook>> GetBorrowedBooksByUser()
        {
            return await _context.BorrowedBooks.Include(b => b.User).ToListAsync();
        }

        public async Task<List<BorrowedBook>> GetBorrowedBooksByBook()
        {
            return await _context.BorrowedBooks.Include(b => b.Book).ToListAsync();
        }


    }
}
