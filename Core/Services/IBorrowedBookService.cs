using LibraryManagementSystem.Core.Dtos;
using LibraryManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core.Services
{
    public interface IBorrowedBookService:IService<BorrowedBook>
    {
        Task<CustomResponseDto<List<BorrowedBookByUserDto>>> GetBorrowedBooksByUser();
        Task<CustomResponseDto<List<BorrowedBookByBookDto>>> GeBorrowedtBooksByBook();
    }
}
