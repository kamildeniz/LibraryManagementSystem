using LibraryManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core.Repositories
{
    public interface IBorrowedRepository : IGenericRepository<BorrowedBook>
    {
        Task<List<BorrowedBook>> GetBorrowedBooksByUser();
        Task<List<BorrowedBook>> GetBorrowedBooksByBook();
    }
}
