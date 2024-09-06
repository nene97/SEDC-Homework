using LibraryApp.DataAccess.Interfaces;
using LibraryApp.Domain.Models;
using LibraryApp.DTOs;
using LibraryApp.Services.Interfaces;
using LibraryApp.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp.Domain.Models.Enums;

namespace LibraryApp.Services.Implementations
{
    public class BookServices : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IAuthorRepository _authorRepository;


        public BookServices(IBookRepository bookRepository, IAuthorRepository authorRepository)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
        }
     


        public void AddBook(AddBookDto addBookDto)
        {
            if (addBookDto == null)
            {
                throw new Exception("Book cant be null");
            }
            if (string.IsNullOrWhiteSpace(addBookDto.Title))
            {
                throw new Exception("Book must contain title");
            }
            if (addBookDto.Description.Length > 500)
            {
                throw new Exception("Description cant be more than 500 characters");
            }
            if (addBookDto.Genre == null)
            {
                throw new Exception("Book must conatin genre");
            }
            Author authorDb = _authorRepository.GetById(addBookDto.AuthorUserId);
            if (authorDb == null)
            {
                throw new Exception("Not found");
            }


            Book newBook = addBookDto.ToBook();
            _bookRepository.Add(newBook);
           


        }

        public void DeleteBook(int id)
        {
            Book bookDb = _bookRepository.GetById(id);
            if (bookDb == null)
            {
                throw new Exception("NO book found");

            }
            _bookRepository.Delete(bookDb); 
        }

       

        

        public List<BookDto> Filter(GenreEnum? genre, int? author)
        {
            if (genre.HasValue)
            {
                var enumValues = Enum.GetValues(typeof(GenreEnum))
                                    .Cast<GenreEnum>()
                                    .ToList();

                if (!enumValues.Contains(genre.Value))
                {
                    throw new Exception("No genre");
                }
            }
            return _bookRepository.Filter((int?)genre, author)                      
                                    .Select(x => x.ToBookDto()).ToList();
        }

        public List<BookDto> GetAllBooks()
        {
            var books = _bookRepository.GetAll();
            return books.Select(x => x.ToBookDto()).ToList();
        }

        public BookDto GetBookById(int id)
        {
            Book boodDb = _bookRepository.GetById(id);
            if(boodDb == null)
            {
                throw new Exception("book not found");
            }
            return boodDb.ToBookDto();
        }

        public void UpdateBook(UpdateBookDto updateBookDto)
        {
            Book bookDb = _bookRepository.GetById(updateBookDto.Id);
            if(bookDb == null)
            {
                throw new Exception("Book cant be null");  
            }
            if (string.IsNullOrEmpty(updateBookDto.Title) || updateBookDto.Title.Length > 50)
            {
                throw new Exception("title  cant be null or longer tahn 50");

            }
            if(updateBookDto.Genre == null)
            {
                throw new Exception("You must add ganre");

            }

            if(updateBookDto.Description.Length > 500)
            {
                throw new Exception("Desc over limit");
            }

            Author authorDb = _authorRepository.GetById(updateBookDto.AuthorUserId);
            if(authorDb == null)
            {
                throw new Exception($"User with {updateBookDto.Id} doesnt exist");
            }
            bookDb.Title = updateBookDto.Title;
            bookDb.Description = updateBookDto.Description;
            bookDb.Genre = updateBookDto.Genre;
            bookDb.AuthorUserId = updateBookDto.AuthorUserId;
            bookDb.AuthorUser = authorDb;

            _bookRepository.Update(bookDb);


        }
    }
}
