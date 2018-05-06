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

        // GET: Reviews/Create
        public ActionResult AddReview()
        {
            return View();
        }

        // POST: Reviews/Create
        [HttpPost]
        public ActionResult AddReview(ReviewsVm  reviewVm)
        {
            try
            {
                Reviews review = new Reviews();
               
                ReviewsVm  reviewsVm = new ReviewsVm() {
                   
                };
                
                if(ModelState.IsValid)
                {

                    review.Rating = reviewsVm.review.Rating;
                }


                // TODO: Add insert logic here

                crud.Insert(review);

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();

                return View();
            }
        }

        // GET: Reviews/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reviews/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reviews/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reviews/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
