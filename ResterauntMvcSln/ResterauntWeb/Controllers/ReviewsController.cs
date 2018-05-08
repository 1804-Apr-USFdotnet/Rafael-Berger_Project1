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
        public ActionResult AddR(int id)
        {

            Reviews review = new Reviews()
            {
                Id = id
            };
            return RedirectToAction("AddReview", review);
        }

        // GET: Reviews/Create
        public ActionResult AddReview(Reviews r)
        {

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
                
                if(ModelState.IsValid)
                {

                
                    crud.Insert(review);
                }


                // TODO: Add insert logic here


                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();

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
            catch
            {
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
            catch
            {
                return View();
            }
        }
    }
}
