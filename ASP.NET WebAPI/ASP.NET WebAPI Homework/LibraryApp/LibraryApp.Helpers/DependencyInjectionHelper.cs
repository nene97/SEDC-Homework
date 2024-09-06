using LibraryApp.DataAccess;
using LibraryApp.DataAccess.Implementations;
using LibraryApp.DataAccess.Interfaces;
using LibraryApp.Domain.Models;
using LibraryApp.Services.Implementations;
using LibraryApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Helpers
{
    public static class DependencyInjectionHelper
    {

        public static void InjectDbContext(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<LibraryAppDbContext>
                (x => x.UseSqlServer(connectionString));
        }


        public static void InjectRepository(IServiceCollection services)
        {
            services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<IAuthorRepository, AuthorRepository>();

        }

        public static void InjectServices(IServiceCollection services)
        {
            services.AddTransient<IBookService, BookServices>();
            services.AddTransient<IAuthorService, AuthorServices>();
        }
    }
}
