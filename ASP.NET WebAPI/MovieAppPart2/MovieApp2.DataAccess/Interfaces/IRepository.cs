using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp2.DataAccess.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);
        List<T> GetAll();
        T GetById(int id);
        List<T> Filter(int? year, int? genre);
        void Update (T entity);
        void Delete (T entity);


    }
}
