using RestaurantData.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantData
{
    public class ApplicationDbContext :DbContext,  IDbContext
    {

        public ApplicationDbContext():base("RestDb")
        {
   

    }
    

        //public override int SaveChanges()
        //{
        //    var AddedEntities = ChangeTracker.Entries().Where(E => E.State == EntityState.Added).ToList();

        //    //AddedEntities.ForEach(E =>
        //    //{
        //    //    E.Property("Created").CurrentValue = DateTime.Now;
        //    //});

        //    var ModifiedEntities = ChangeTracker.Entries().Where(E => E.State == EntityState.Modified).ToList();

        //    //ModifiedEntities.ForEach(E =>
        //    //{
        //    //    E.Property("Modified").CurrentValue = DateTime.Now;
        //    //});
        //    return base.SaveChanges();
        //}

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Reviews> Reviews { get; set; }

        IDbSet<TEntity> IDbContext.Set<TEntity>()
        {
            return base.Set<TEntity>();
        }
    }
}
