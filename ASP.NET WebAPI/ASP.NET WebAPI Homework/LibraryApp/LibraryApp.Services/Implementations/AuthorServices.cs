using LibraryApp.DataAccess.Interfaces;
using LibraryApp.Domain.Models;
using LibraryApp.DTOs;
using LibraryApp.Mappers;
using LibraryApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Services.Implementations
{
    public class AuthorServices : IAuthorService
    {
        private readonly IAuthorRepository _authorRespository;

        public AuthorServices(IAuthorRepository authorRespository)
        {
            _authorRespository = authorRespository;
        }


        public void AddAuthor(AddAuthorDto addAuthorDto)
        {
            if (addAuthorDto == null)
            {
                throw new Exception("Author cant be null");
            }
            if(string.IsNullOrEmpty(addAuthorDto.LastName) || string.IsNullOrEmpty(addAuthorDto.LastName))
            {
                throw new Exception("Author must have name and lastname");
            }

            Author authorDb = _authorRespository.GetAuthorByName(addAuthorDto.FirstName, addAuthorDto.LastName);
            if (authorDb != null)
            {
                throw new Exception("Author alredy exists");
            }
            Author newAuthor = addAuthorDto.ToAuthor();

            _authorRespository.Add(newAuthor); 






        }

        public void DeleteAuthor(int id)
        {
            Author authorDb = _authorRespository.GetById(id);
            if (authorDb == null)
            {
                throw new Exception("Author doesnt exists");

            }
           _authorRespository.Delete(authorDb);

        }

        public List<AuthorDto> GetAllAuthors()
        {
            var authors = _authorRespository.GetAll();
            return authors.Select(x => x.ToAuthorDto()).ToList(); 
            
        }

        public AuthorDto GetAuthorById(int id)
        {
         Author authorDb =    _authorRespository.GetById(id);
            if(authorDb == null)
            {
                throw new Exception("No author found");
            }
            
            return authorDb.ToAuthorDto();

        }

        public void UpdateAuthor(UpdateAuthorDto updateAuthorDto)
        {
            Author authorDb = _authorRespository.GetById(updateAuthorDto.Id);
            if (authorDb == null)
            {
                throw new Exception("No author found");

            }
            if (updateAuthorDto == null)
            {
                throw new Exception("Author cant be null");
            }
            if (string.IsNullOrEmpty(updateAuthorDto.FirstName) || string.IsNullOrEmpty(updateAuthorDto.LastName))
            {
                throw new Exception("Author must have name and lastname");
            }

            authorDb.FirstName = updateAuthorDto.FirstName;
            authorDb.LastName = updateAuthorDto.LastName;
            
            _authorRespository.Update(authorDb);

        }
    }
}
