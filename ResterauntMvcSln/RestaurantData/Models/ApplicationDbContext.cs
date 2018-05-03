using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantData.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext():base("RestDb")
        {


        }

        public DbSet<Restauraunt> Resteraunts { get; set; }
    }
}
