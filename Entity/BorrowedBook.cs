using Entity;

namespace LibraryManagementSystem.Entity
{
    public class BorrowedBook : BaseEntity
    {

        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowedDate { get; set; }
        public DateTime Deadline { get; set; }
        public bool GivingBack { get; set; }
    }
}
