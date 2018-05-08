using AutoMapper;
using Rest.DAL;
using Rest.DAL.Repositories;
using RestaurantData.Models;
using ResterauntWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantData;
using Rest.DAL.DTOs;
using System.Data.Entity;
using RestaurantData.Models;


namespace ResterauntWeb.Controllers
{
    public class RestaurantsController : Controller
    {

        ICrud<Restaurant> crud;
        IDbContext db;

        public RestaurantsController()
        {
            db = new ApplicationDbContext();
            crud = new Crud<Restaurant>(db);

        }



      [HttpPost]
        public List<Restaurant> GetUserInput(RestaurantVm mv , string input )
        {
             SearchAndSortRestaurants Search = new SearchAndSortRestaurants();

            var mode = mv.SelectedMethod;
            List < RestaurantVm > restvm = new List<RestaurantVm>();
            var rest = crud.Table.ToList();
            try
            {
                restvm = rest.ConvertAll(x => new RestaurantVm{ Id = x.Id });

                switch (mode)
                {
                    case "Name":
                        return Search.SearchResturant(input, rest);

                }

            }
            catch (Exception)
            {


            }
            return rest;

        }
    


    [HttpPost]
        public string GetSortMethod(RestaurantVm mv, string input)
        {
            string SelectedValue = string.Empty;
            TempData["SortMethod"] = mv.SelectedMethod;
            try
            {
                SelectedValue  = mv.SelectedMethod;
          
               

            }
            catch(Exception ex)
            {


            }
            return SelectedValue;

        }

        public ActionResult SearchResults(RestaurantVm r)
        {

            return PartialView("SearchResults", r); 
        }

        public ActionResult Index(string option, string search)
        {


            if (option == "Name")
            {
             
                return View(crud.Table.Where(x => x.Name.StartsWith(search) || search == null).ToList());
            }
            else if (option == "City")
            {
                return View(crud.Table.Where(x => x.City.StartsWith(search) || search == null).ToList());
            }
            else
            {

                return View(crud.Table.Where(x => x.Name.StartsWith(search) || search == null).ToList());
            }

        }
        [HttpPost]
        public ActionResult SearchResult(RestaurantVm restvm)
        {
 
            List<Restaurant> rest = new List<Restaurant>();
            SearchAndSortRestaurants Search = new SearchAndSortRestaurants();
            rest = crud.Table.ToList();
            rest = Search.SearchResturant(restvm.Name, rest);


            foreach (var item in rest)
            {
                restvm.Id = item.Id;
                restvm.Name = item.Name;

            }

            return RedirectToAction("SearchResults");
        }

        public ActionResult RestList()
        {
            RestaurantVm restVm = new RestaurantVm();
            FeaturedRestaurants featuredRestaurants = new FeaturedRestaurants();

            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem { Text = "City", Value = "city", Selected = true });
            items.Add(new SelectListItem { Text = "Name", Value = "Name" });

            restVm.SortMethods = items;
            var listItems = restVm.SortMethods;
      

            restVm.restaurants = crud.Table.Include(x => x.reviews).ToList();
             var ListOfIds = featuredRestaurants.Top3Rest().ToList().Select(x => x.Id);
            restVm.Featuredrestaurants =   crud.Table.Where(x => ListOfIds.Contains(x.Id)).ToList();


            return View(restVm);
        }

        [HttpGet]
        public ActionResult GetSortMethod(string selectedSort)
        {
            string SelectedValue = selectedSort;
            return View(selectedSort);
        }



        [HttpPost]
        public ActionResult Edit(int id)
        {
            
            try
            {



            }
            catch
            {


            }



            return RedirectToAction("Index");

        }


        public ActionResult Delete(int id)
        {
            try
            {
                Restaurant restToDelete = crud.Table.Where(x => x.Id == id).FirstOrDefault();
                crud.Delete(restToDelete);

            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);

            }
            return RedirectToAction("RestList");
        }
    }
}


