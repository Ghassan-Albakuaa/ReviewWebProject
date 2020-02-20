using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Review2.Models;
using Review2.Repositories;

namespace Review2.Controllers
{
    public class ReviewController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}


        private readonly IRepository<Review> reviewRepo;

        public ReviewController(IRepository<Review> reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }
        public ViewResult Index()
        {
            var model = reviewRepo.GetAll();
            return View(model);

        }

        // GET: /Details/
        public ActionResult Details(int id)
        {
            var review = reviewRepo.Find2(id);
            return View(review);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int id, Review review)
        {

            try
            {

                reviewRepo.Add(id, review);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var review = reviewRepo.Find2(id);
            return View(review);
        }

        // POST: product/Edit/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Review review)
        {
            try
            {
                // TODO: Add update logic here
                reviewRepo.Update( review);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: product/Delete/
        public ActionResult Delete(int id)
        {
            var review = reviewRepo.Find2(id);
            return View(review);
        }

        // POST: product/Delete/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ProductModel product)
        {
            try
            {
                reviewRepo.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Review(int id)
        {
            var review = reviewRepo.Find2(id);
            return View(review);
        }

        // POST: review/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Review(int id, Review review)
        {
            try
            {
                // TODO: Add update logic here
                reviewRepo.Review(id, review);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Remove_Review(int id)
        {
            var review = reviewRepo.Find2(id);
            return View(review);
        }

        // POST: product/Remove_Review/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Remove_Review(int id, Review review)
        {
            try
            {
                // TODO: Add update logic here
                reviewRepo.Remove_Review(id, review);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}