using LibraryApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.DTOs
{
    public class AuthorDto
    {
        public string FullName { get; set; }
        public List<BookDto> Books { get; set; }
    }
}
