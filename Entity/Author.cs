using LibraryManagementSystem.Entity;

namespace Entity
{
    public class Author : BaseEntity
    {
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
