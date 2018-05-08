using Rest.DAL;
using Rest.DAL.Repositories;
using RestaurantData;
using RestaurantData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
 

namespace RestaurantBL
{

    public class UserHandler {

        ICrud<Restaurant> crud;
        IDbContext db;
        public SortingFunctions sortFunc = new SortingFunctions();
      

        public UserHandler()
        {
            db = new ApplicationDbContext();
            crud = new Crud<Restaurant>(db);

        }
        //public List<Restaurant> GetUserInput( string input)
        //{

        //    var mode = 
        //    List<Restaurant> rest = new List<Restaurant>();
        //    rest = crud.Table.ToList();
        //    switch (mode)
        //    {
        //        case "City":
        //            return sortFunc.FilterByCity(input, rest);

        //    }
        //    return rest;

        //}
    }
}
