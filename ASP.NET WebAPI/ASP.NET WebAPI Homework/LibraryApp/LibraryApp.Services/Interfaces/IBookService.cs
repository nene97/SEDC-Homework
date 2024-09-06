using LibraryApp.Domain.Models;
using LibraryApp.Domain.Models.Enums;
using LibraryApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Services.Interfaces
{
    public interface IBookService
    {

        List<BookDto> GetAllBooks();
        BookDto GetBookById(int id);

        List<BookDto> Filter(GenreEnum? genre, int? author);
        void AddBook(AddBookDto addBookDto);

        void UpdateBook(UpdateBookDto updateBookDto);

        void DeleteBook(int id);
    }
}
