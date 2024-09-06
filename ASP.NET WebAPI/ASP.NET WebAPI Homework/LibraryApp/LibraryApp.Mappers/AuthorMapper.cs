using LibraryApp.Domain.Models;
using LibraryApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Mappers
{
    public static class AuthorMapper
    {
        public static Author ToAuthor(this AddAuthorDto addAuthorDto)
        {
            return new Author
            {
                FirstName = addAuthorDto.FirstName,
                LastName = addAuthorDto.LastName,
                

            };
        }


        public static AuthorDto ToAuthorDto(this Author author)
        {
            return new AuthorDto
            {
                FullName = $"{author.FirstName} {author.LastName}",
                Books = author.Books.Select(b => b.ToBookDto()).ToList()
            };
        }
    }
}
