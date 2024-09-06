using LibraryApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.DataAccess.Interfaces
{
    public interface  IAuthorRepository :IRepository<Author>
    {
        Author GetAuthorByName(string name , string lastname);
    }
}
