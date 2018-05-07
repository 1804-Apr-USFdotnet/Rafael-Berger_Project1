using Rest.DAL;
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

    public class SortFunctions {

        ICrud<Restaurant> crud;
        IDbContext db;

        public SortFunctions()
        {
            db = new ApplicationDbContext();
            crud = new Crud<Restaurant>(db);

        }
        public List<Restaurant> GetUserInput(string mode, string input)
        {
            List<Restaurant> rest = new List<Restaurant>();
            rest = crud.Table.ToList();
            switch (mode)
            {
                case "City":
                    return FilterByCity(input, rest);

            }
            return rest;

        }
    }
}
