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
  public  class SortingFunctions
    {

        ICrud<Restaurant> crud;
        ICrud<Reviews> reviewCrud;
        IDbContext db;


        public SortingFunctions()
        {
            
            db = new ApplicationDbContext();
            crud = new Crud<Restaurant>(db);

        }

        
 
        public List<Restaurant> FilterByCity(string userInput, List<Restaurant> restList)
        {
            List<Restaurant> rest = new List<Restaurant>();
            try
            {

            return restList.Where(x => x.City.StartsWith(userInput)).ToList();

            }
            catch
            {


            }
            return rest;

        }
        //public List<Restaurant> SortByMostReviewed()
        //{
        //    List<Restaurant> rest = new List<Restaurant>();
        //    List<Reviews> reviewIds = new List<Reviews>();
        //    try
        //    {

        //       var  reviewId = reviewCrud.Table.GroupBy(x => x.Restaurant.Id, r => r.Rating)
        //            .OrderByDescending(m => m.Count()).SelectMany(m => m).ToList();

        //    }
        //    catch
        //    {


        //    }
        //    return rest;

        //}
        //public Restaurant SortByNameAscending()
        //{


        //}



    }
}
