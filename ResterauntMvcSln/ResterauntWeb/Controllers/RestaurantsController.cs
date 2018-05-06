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
using ResterauntWeb.ViewModels;

namespace ResterauntWeb.Controllers
{
    public class RestaurantsController : Controller
    {

        ICrud<Restauraunt> crud;


        IDbContext db;
        public RestaurantsController()
        {
            db = new ApplicationDbContext();
            crud = new Crud<Restauraunt>(db);

        }


        public ActionResult sortedRestaurants(RestaurantVm mv)
        {
            string SelectedValue = mv.SelectedMethod;



            //switch (SelectedValue)
            //{
            //    case "Name":
            //     SortByName

            //    default:

            //        break;
            //}
            return View(mv);


        }

        public ActionResult DisplaySearchResults(string searchText)
        {
            RestaurantVm rest = new RestaurantVm();
           rest.SearchResults = crud.Table.Where(x => x.Name.StartsWith(searchText)).DefaultIfEmpty().ToList();
            return PartialView("SearchResults", rest);
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
      

            restVm.restaurants = crud.Table.ToList();
            restVm.Featuredrestaurants = featuredRestaurants.FeaturedRest().ToList();


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
    }
}


