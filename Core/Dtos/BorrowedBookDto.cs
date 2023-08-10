using LibraryManagementSystem.Core.Dtos;

namespace LibraryManagementSystem.Core.Dtos
{
    public class BorrowedBookDto : BaseDto
    {

        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowedDate { get; set; }
        public DateTime Deadline { get; set; }
        public bool GivingBack { get; set; }


    }
}
