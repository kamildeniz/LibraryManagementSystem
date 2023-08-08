using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core.Dtos
{
    public class BookByAuthorDto : BookDto
    {
        public AuthorDto Author { get; set; }
    }
}
