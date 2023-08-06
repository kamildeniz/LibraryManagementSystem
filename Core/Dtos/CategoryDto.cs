using LibraryManagementSystem.Entity;

namespace LibraryManagementSystem.Core.Dtos
{
    public class CategoryDto : BaseDto
    {
        public string? Name { get; set; }
        public ICollection<Book> Books { get; set; }


    }
}
