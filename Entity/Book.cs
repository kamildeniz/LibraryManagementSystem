using Entity;

namespace LibraryManagementSystem.Entity
{
    public class Book : BaseEntity
    {

        public int Stock { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public byte[]? CoverPhoto { get; set; }
    }
}