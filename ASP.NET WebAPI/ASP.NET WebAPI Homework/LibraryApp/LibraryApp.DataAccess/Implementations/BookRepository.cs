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
    public class BookRepository : IBookRepository
    {
        private LibraryAppDbContext _dbContext;

        public BookRepository(LibraryAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Book entity)
        {

            _dbContext.Books.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Book entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
        }

       

        public List<Book> GetAll()
        {
           return _dbContext.Books.Include(x => x.AuthorUser).ToList(); 
        }

        public Book GetById(int id)
        {
            return _dbContext.Books.Include(x => x.AuthorUser).FirstOrDefault(x => x.Id == id);
        }

        public void Update(Book entity)
        {
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
        }

        List<Book> IBookRepository.Filter(int? genre, int? author)
        {

            IQueryable<Book> query = _dbContext.Books.Include(b => b.AuthorUser); // Include the related author

            if (author != null)
            {
                query = query.Where(x => x.AuthorUserId == author);
            }

            if (genre != null)
            {
                query = query.Where(x => (int)x.Genre == genre.Value);
            }

            return query.ToList();
        }
    }
}
