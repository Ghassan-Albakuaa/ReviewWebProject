using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Review2.Repositories;

namespace Review2.Controllers
{
    public class ProductController : Controller
    {
        public ViewResult ProductIndex()
        {

            ProductRepository productRepo = new ProductRepository();

            var model = productRepo.GetAll();

            return View(model);
        }
    }
}