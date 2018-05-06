using RestaurantData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest.DAL
{
   public interface ICrud<T> where T : BaseEntity
    {
        // T GetDbContext { get; }
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> Table { get; }

    }
}
