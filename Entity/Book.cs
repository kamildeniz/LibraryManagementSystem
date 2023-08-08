﻿using Entity;

namespace LibraryManagementSystem.Entity
{
    public class Book : BaseEntity
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public string? PhotoPath { get; set; }
        public Category Category { get; set; }
        public Author Author { get; set; }
        public ICollection<BorrowedBook> BorrowedBooks { get; set; }
    }
}