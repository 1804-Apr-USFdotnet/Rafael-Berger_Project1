using AutoMapper;
using Rest.DAL;
using RestaurantData.Models;
using ResterauntWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ResterauntWeb.Controllers
{
    public class RestaurantsController : Controller
    {
        public RestaurantRepository _db = new RestaurantRepository();
        public RestaurantsController()
        {


        }
        public RetaurantDto ReturnMostReviewedRest()
        {

            RetaurantDto restvm = new RetaurantDto();
            return restvm;


        }

        public ActionResult RestList()
        {


            var rest = _db.GetAll();
            return View(rest);
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


