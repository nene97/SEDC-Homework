using LibraryApp.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.DTOs
{
    public class BookDto
    {

        public string Title { get; set; }
        public string? Description { get; set; }

        public string Genre { get; set; }

        public string AuthorFullName { get; set; }
    }
}
