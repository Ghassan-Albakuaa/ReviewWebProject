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
        
        //private readonly IRepository<ProductModel> productRepo;

       ProductRepository productRepo = new ProductRepository();


        public ViewResult ProductIndex()
        {                       
            var model = productRepo.GetAll();
            return View(model);

        }
                    
            

        // GET: Cars/Details/5
        public ActionResult Details(int id)
        {
            var product = productRepo.Find(id);
            return View(product);
        }




    }
}