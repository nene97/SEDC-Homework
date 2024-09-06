using LibraryApp.Domain.Models;
using LibraryApp.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.DTOs
{
    public class AddBookDto
    {
        public string Title { get; set; }
        public string? Description { get; set; }

        public GenreEnum Genre { get; set; }

        public int AuthorUserId { get; set; }

        
    }
}
