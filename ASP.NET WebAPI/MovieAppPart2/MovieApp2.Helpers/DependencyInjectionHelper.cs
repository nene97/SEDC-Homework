using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieApp2.DataAccess;
using MovieApp2.DataAccess.Implementation;
using MovieApp2.DataAccess.Interfaces;
using MovieApp2.Domain.Models;
using MovieApp2.Services.Implementation;
using MovieApp2.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp2.Helpers
{
    public static class DependencyInjectionHelper
    {
        public static void InjectDbContext(IServiceCollection services , string connectionString)
        {
            services.AddDbContext<MovieAppDbContext>
                (x => x.UseSqlServer(connectionString));    

        } 

        public static void InjectServices(IServiceCollection services)
        {
            services.AddTransient<IMovieServices, MovieServices>();
            services.AddTransient<IUserService , UserServices>();
        }
        public static void InjectRepository(IServiceCollection services)
        {
            services.AddTransient<IRepository<Movie> , MovieRepository>(); 
            services.AddTransient<IUserRepository , UserRepository>();
        }


    }
}
