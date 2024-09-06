using LibraryApp.Domain.Models;
using LibraryApp.Domain.Models.Enums;
using LibraryApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Mappers
{
    public static class BookMapper
    {

        public static Book ToBook(this AddBookDto addBookDto)
        {
            return new Book
            {
                Title = addBookDto.Title,
                Description = addBookDto.Description,
                Genre = addBookDto.Genre,
                AuthorUserId = addBookDto.AuthorUserId
            };
        }
        public static BookDto ToBookDto(this Book book)
        {
            return new BookDto
            {
                Title = book.Title,
                Description = book.Description,
                Genre = Enum.GetName(typeof(GenreEnum), book.Genre),
                AuthorFullName = $"{book.AuthorUser.FirstName} {book.AuthorUser.LastName}"
            };
        }
    }
}
