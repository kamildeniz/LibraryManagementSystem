

namespace LibraryManagementSystem.Core.Dtos
{
    public class BorrowedBookByBookDto:BorrowedBookDto
    {
        public BookDto Book { get; set; }
    }
}
