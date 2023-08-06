using Entity;
using LibraryManagementSystem.Entity;

namespace LibraryManagementSystem.Core.Dtos
{
    public class BookDto : BaseDto
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public byte[]? CoverPhoto { get; set; }

    }
}
