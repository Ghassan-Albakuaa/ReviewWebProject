using Review2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Review2.Repositories
{
    public class ProductDBRepository : IRepository<ProductModel>
    {
        
       ProductDbContext db;

    public ProductDBRepository(ProductDbContext _db)
    {
        db = _db;
    }
    public void Add(int id, ProductModel product)
    {
            db.Products.Add(product);
            db.SaveChanges();
        // return RedirectToAction(nameof(Index));
    }


    public IEnumerable<ProductModel> GetAll()
    {
        return db.Products.ToList();
    }


    public ProductModel Find(int id)
    {
        var product = db.Products.SingleOrDefault(b => b.Id == id);
        return product;

    }



    public void Update(int id, ProductModel product)
    {
            db.Update(product);
            db.SaveChanges();

        }
    public void Delete(int id)
    {

            var product = Find(id);

            db.Products.Remove(product);

            db.SaveChanges();
        }

    public void Review(int id, ProductModel product)
    {
        var Product = Find(id);


        Product.Review = product.Review;

            db.SaveChanges();

        }

    public void Remove_Review(int id, ProductModel product)
    {
        var Product = Find(id);

        Product.Review = "";
    }
}
}

