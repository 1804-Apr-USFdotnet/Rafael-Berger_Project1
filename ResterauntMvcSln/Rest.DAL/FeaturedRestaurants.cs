using Rest.DAL.Repositories;
using RestaurantData;
using RestaurantData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest.DAL
{
  public  class FeaturedRestaurants
    {

        public IEnumerable<Restaurant> FeaturedRest()
        {
            ICrud<Restaurant> restCrud;
            ICrud<Reviews> revCrud;
            IDbContext db;
            db = new ApplicationDbContext();
            restCrud = new Crud<Restaurant>(db);
            revCrud = new Crud<Reviews>(db);
            var featuredRest = restCrud.Table.OrderByDescending(x => x.AvgRating).Take(3);
            return featuredRest;


        }

    }
}
