using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Review2.Repositories;
using Review2.Models;


namespace Review2.Controllers
{
    public class ProductController : Controller
    {
        
       private readonly IRepository<ProductModel> productRepo;

       public ProductController(IRepository<ProductModel> productRepo)
        {
            this.productRepo = productRepo;
        }
        public ViewResult Index()
        {                       
            var model = productRepo.GetAll();
            return View(model);

        }
                    
            

        // GET: /Details/
        public ActionResult Details(int id)
        {
            var product = productRepo.Find(id);
            return View(product);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int id,ProductModel product)
        {
            
            try
            {
              
                productRepo.Add(id,product);
              //  productDictionary.Add(4, product);
              //  ProductRepository.Add(4, product);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var product = productRepo.Find(id);
            return View(product);
        }

        // POST: product/Edit/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductModel product)
        {
            try
            {
                // TODO: Add update logic here
                productRepo.Update(id, product);
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
            var product = productRepo.Find(id);
            return View(product);
        }

        // POST: product/Delete/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ProductModel product)
        {
            try
            {
                productRepo.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }




        public ActionResult Review(int id)
        {
            var product = productRepo.Find(id);
            return View(product);
        }

        // POST: product/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Review(int id, ProductModel product)
        {
            try
            {
                // TODO: Add update logic here
                productRepo.Review(id, product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}