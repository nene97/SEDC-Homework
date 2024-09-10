using MovieApp2.DataAccess.Interfaces;
using MovieApp2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp2.DataAccess.Implementation
{
    public class MovieRepository : IRepository<Movie>
    {
        private MovieAppDbContext _dbContext;

        public MovieRepository(MovieAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Movie entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Movie entity)
        {
           _dbContext.Movies.Remove(entity);
            _dbContext.SaveChanges();   
        }

        public List<Movie> Filter(int? year, int? genre)

        {

            if (genre == null)
            {
                return _dbContext.Movies.Where(x => x.Year == year).ToList();
            }
            if (year == null)
            {
                return _dbContext.Movies.Where(x => (int)x.Genre == genre.Value).ToList();

            }
            return _dbContext.Movies.Where(x => x.Year == year && (int)x.Genre == genre.Value).ToList(); 

        }

        public List<Movie> GetAll()
        {
            return _dbContext.Movies.ToList();  
        }

        public Movie GetById(int id)
        {
            return _dbContext.Movies.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Movie entity)
        {
            _dbContext.Movies.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
