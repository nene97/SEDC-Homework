using LibraryApp.DataAccess.Interfaces;
using LibraryApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.DataAccess.Implementations
{
    public class AuthorRepository : IAuthorRepository
    {
        private LibraryAppDbContext _dbContext;

        public AuthorRepository(LibraryAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void Add(Author entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Author entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
        }

      

        public List<Author> GetAll()
        {
            return _dbContext.Authors.Include(x => x.Books).ToList();   
        }

        

        public Author GetAuthorByName(string name, string lastname)
        {
            return _dbContext.Authors.FirstOrDefault(x => x.FirstName.ToLower() == name.ToLower() && x.LastName.ToLower() == lastname.ToLower());
        }

        public Author GetById(int id)
        {
            return _dbContext.Authors.Include(x => x.Books).FirstOrDefault(x => x.Id == id);
        }

        public void Update(Author entity)
        {
           _dbContext.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
