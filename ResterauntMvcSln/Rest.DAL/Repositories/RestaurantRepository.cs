using AutoMapper;
using Rest.DAL.DTOs;
using RestaurantData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest.DAL
{
  public   class RestaurantRepository : Icrud<RestaurantDto>
    {

        private ApplicationDbContext _db = new ApplicationDbContext();
        public RestaurantRepository(ApplicationDbContext db)
        {
            db = _db;


        }

        public RestaurantRepository()
        {
        }

        public IEnumerable<RestaurantDto> GetAll(string query = null)
        {
            var RestaurantQuery = _db.Resteraunts.ToList();


     //       if (!String.IsNullOrWhiteSpace(query))
            //    RestaurantQuery = RestaurantQuery.Where(c => c.Name.Contains(query));

            var restaurantDto = RestaurantQuery
                .ToList()
                .Select(Mapper.Map<Restauraunt, RestaurantDto>).ToList();
            return restaurantDto;
        }


        public RestaurantDto GetById(int id)
        {
            var rest = _db.Resteraunts.SingleOrDefault(c => c.Id == id);

           // if (rest == null)
           

            return Mapper.Map<Restauraunt, RestaurantDto>(rest);
        }


        public void Add(RestaurantDto restaraunt)
        {

            var rest = Mapper.Map<RestaurantDto, Restauraunt>(restaraunt);
            _db.Resteraunts.Add(rest);
            _db.SaveChanges();

            
        }


       
        public void UpdateRestaurant(int id, RestaurantDto RetaurantDto)
        {


            var RestaurantInDb = _db.Resteraunts.SingleOrDefault(c => c.Id == id);

       //     if (customerInDb == null)
       

            Mapper.Map(RetaurantDto, RestaurantInDb);

            _db.SaveChanges();

        }

        
        public void DeleteRestaurant(int id)
        {
            var RestaurantInDb = _db.Resteraunts.SingleOrDefault(c => c.Id == id);

        //    if (customerInDb == null)
    

            _db.Resteraunts.Remove(RestaurantInDb);
            _db.SaveChanges();

        }

        //public IEnumerable<RestaurantDto> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        public RestaurantDto GetById()
        {
            throw new NotImplementedException();
        }

   
    }
}
