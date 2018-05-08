using Newtonsoft.Json;
using NLog;
using Rest.DAL;
using Rest.DAL.Repositories;
using RestaurantData;
using RestaurantData.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarauntReviews.bl
{

    public static class SerializeAndDeserialize
    {

       public static ICrud<Restaurant> crud;
       public static IDbContext db;

         
        

        public static string ConvertToJson()
        {


            db = new ApplicationDbContext();
            crud = new Crud<Restaurant>(db);

            string json = string.Empty;
            try
            {
                var Rest = crud.Table.ToList();
                json = JsonConvert.SerializeObject(Rest);
            }

            catch (Exception ex)
            {

                Logger logger = LogManager.GetLogger("databaseLogger");

                // add custom message and pass in the exception
                logger.Error(ex, "Error");
            }

            return json;
        }
        public static  List<Restaurant> ConvertJsonToList(string JsonObject)
        {
            List<Restaurant> deserializedObj = new List<Restaurant>();
            try
            {
                deserializedObj = JsonConvert.DeserializeObject<IEnumerable<Restaurant>>(JsonObject).ToList();

           

            }
            catch (Exception ex)
            {

                Logger logger = LogManager.GetLogger("databaseLogger");

                // add custom message and pass in the exception
                logger.Error(ex, "Error");

            }

            //Console.ReadLine();
            return deserializedObj;

        }




     


    }


}