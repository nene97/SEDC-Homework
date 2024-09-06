using LibraryApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Services.Interfaces
{
    public interface IAuthorService
    {
        void AddAuthor(AddAuthorDto addAuthorDto);
        void UpdateAuthor(UpdateAuthorDto updateAuthorDto);
        void DeleteAuthor(int id);

        AuthorDto GetAuthorById(int id);
        List<AuthorDto> GetAllAuthors();

    }
}
