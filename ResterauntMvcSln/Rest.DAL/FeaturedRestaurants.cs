using MoreLinq;
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

        public IEnumerable<Restaurant> Top3Rest()
        {
            ICrud<Restaurant> restCrud;
            ICrud<Reviews> revCrud;
            IDbContext db;
            db = new ApplicationDbContext();
            restCrud = new Crud<Restaurant>(db);
            revCrud = new Crud<Reviews>(db);
            List<Restaurant> restList = new List<Restaurant>();
            //Restaurant rest = new Restaurant();
    
            try
            {
                var TopRestauraunts = revCrud.Table
                   .GroupBy(g => g.Restaurant.Id, r => r.Rating)
                   .Select(g => new
                   {
                       RestId = g.Key,
                       Rating = g.Average()
                 
                   }).DistinctBy(x => x.RestId).OrderByDescending(x => x.Rating).Take(3);
                foreach (var item in TopRestauraunts)
                {
                    var rest = new Restaurant()
                    {
                        Id = item.RestId,
                        AvgRating = item.RestId

                        

                    };
                    restList.Add(rest);
                }

             



            } 
            catch(Exception ex)
            {


            }
    
            return restList;


        }

    }
}
