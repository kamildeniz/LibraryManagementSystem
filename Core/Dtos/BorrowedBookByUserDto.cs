

namespace LibraryManagementSystem.Core.Dtos
{
    public class BorrowedBookByUserDto:BorrowedBookDto
    {
        public UserDto User{ get; set; }
    }
}
