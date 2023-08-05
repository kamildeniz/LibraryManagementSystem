﻿using Entity;

namespace LibraryManagementSystem.Entity
{
    public class Category : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
