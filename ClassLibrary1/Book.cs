using Entity;

namespace ClassLibrary1
{
    public class Book : BaseEntity
    {

        public int Stock { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
    }
}