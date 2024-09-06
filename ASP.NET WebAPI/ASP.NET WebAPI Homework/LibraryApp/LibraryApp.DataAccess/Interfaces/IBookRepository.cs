using LibraryApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.DataAccess.Interfaces
{
    public interface IBookRepository :IRepository<Book>
    {
        List<Book> Filter(int? genre, int? author);

    }
}
