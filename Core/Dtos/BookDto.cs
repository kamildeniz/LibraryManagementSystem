namespace LibraryManagementSystem.Core.Dtos
{
    public class BookDto : BaseDto
    {
        public int Stock { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
    }
}
