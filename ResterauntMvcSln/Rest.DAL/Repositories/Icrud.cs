using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest.DAL
{
    interface Icrud<T>
    {
        // T GetDbContext { get; }
        IEnumerable<T> GetAll(string query);
        T GetById(int id);
        void Add(T entity);


    }
}
