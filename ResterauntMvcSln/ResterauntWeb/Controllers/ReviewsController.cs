using NLog;
using Rest.DAL;
using Rest.DAL.Repositories;
using RestaurantData;
using RestaurantData.Models;
using ResterauntWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResterauntWeb.Controllers
{
    public class ReviewsController : Controller
    {

        ICrud<Reviews> crud;
        ApplicationDbContext application = new ApplicationDbContext();

        ICrud<Restaurant> resCrud;
        IDbContext db;

        public ReviewsController()
        {
            db = new ApplicationDbContext();
            crud = new Crud<Reviews>(db);

        }

        // GET: Reviews
        public ActionResult Index()
        {
            return View();
        }

        // GET: Reviews/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult AddR(int id)
        {

            Reviews review = new Reviews()
            {
                Id = id
            };
            return RedirectToAction("AddReview", review);
        }

        // GET: Reviews/Create
        public ActionResult AddReview( int id )
        {
            ViewBag.id = id;
            Reviews r = new Reviews();
            return View(r);
        }

        // POST: Reviews/Create
        [HttpPost ]
        public ActionResult AddRev(Reviews  review)
        {
            try
            {

                ReviewsVm  reviewsVm = new ReviewsVm() {
                   
                };
                Restaurant restaurant = new Restaurant();
                application.Entry<Reviews>(review).Reference("Restaurant").Load();
          var id =      resCrud.Table.Where(x => x.Name == review.Restaurant.Name).Select(x => x.Id).FirstOrDefault();
                Reviews reviews = new Reviews()
                {
                    
                    Restaurant = resCrud.Table.Where(x => x.Name.StartsWith(review.Restaurant.Name)).FirstOrDefault(),
                    Rating = review.Rating,
                    Comments = review.Comments,
                   

            };

                
                    crud.Insert(reviews);
                


                return RedirectToAction("RestList", "Restaurants" ,null);
            }
            catch(Exception ex)
            {
                Logger logger = LogManager.GetLogger("databaseLogger");

                // add custom message and pass in the exception
                logger.Error(ex, "Error");

                return View();
            }
        }

        // GET: Reviews/Edit/5
        public ActionResult Edit(Reviews review)
        {
            return View(review);
        }

        // POST: Reviews/Edit/5
        [HttpPost]
        public ActionResult EditReview(Reviews review )
        {
            try
            {
                // TODO: Add update logic here
                crud.Update(review);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                Logger logger = LogManager.GetLogger("databaseLogger");

                // add custom message and pass in the exception
                logger.Error(ex, "Error");
                return View();
            }
        }

        // GET: Reviews/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: Reviews/Delete/5
        [HttpPost]
        public ActionResult Delete(Reviews review)
        {
            try
            {
                // TODO: Add delete logic here
                crud.Delete(review);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                Logger logger = LogManager.GetLogger("databaseLogger");

                // add custom message and pass in the exception
                logger.Error(ex, "Error");
                return View();
            }
        }
    }
}
