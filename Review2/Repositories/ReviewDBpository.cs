using Review2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Review2.Repositories
{
    public class ReviewDBpository : IRepository<Review>
    {
        ProductDbContext db;

        public ReviewDBpository(ProductDbContext _db)
        {
            db = _db;
        }

        public void Add(int id, Review review)
        {
            db.Reviews.Add(review);
            db.SaveChanges();
            //reviewDictionary.Add(id, review);

            // return RedirectToAction(nameof(Index));
        }


        public IEnumerable<Review> GetAll()
        {
            return db.Reviews.ToList();
        }






        public Review Find(int id)
        {
            var review = db.Reviews.SingleOrDefault(b => b.Id == id);
            return review;
        }



        public void Update(int id, Review review)
        {
            db.Update(review);
            db.SaveChanges();


        }
        public void Delete(int id)
        {
            var review = Find(id);
          db.Remove(review);
            db.SaveChanges();
        }

        //public void Review(int id, ProductModel product)
        //{
        //    var Product = Find(id);


        //    Product.Review = product.Review;

        //}

        //public void Remove_Review(int id, ProductModel product)
        //{
        //    var Product = Find(id);

        //    Product.Review = "";
        //}

        IEnumerable<Review> IRepository<Review>.GetAll()
        {
            throw new NotImplementedException();
        }





        public void Review(int id, Review review)
        {
            throw new NotImplementedException();
        }

        public void Remove_Review(int id, Review product)
        {
            throw new NotImplementedException();
        }

        ProductModel IRepository<Review>.Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
