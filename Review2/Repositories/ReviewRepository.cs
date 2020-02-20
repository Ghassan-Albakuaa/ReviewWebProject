using Review2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Review2.Repositories
{
    public class ReviewRepository : IRepository<Review>
    {
        public Dictionary<int, Review> reviewDictionary;

        public ReviewRepository()
        {
            reviewDictionary = new Dictionary<int, Review>()
            {
                {1, new Review(1 , "Pac-Man", "Yellow eating monster")},
                {2, new Review(2 , "Pac-Man", "Yellow eating monster")},
                {3, new Review(3 , "Pac-Man", "Yellow eating monster")}

            };
        }

        public void Add(int id, Review review)
        {
            reviewDictionary.Add(id, review);

            // return RedirectToAction(nameof(Index));
        }


        public IEnumerable<Review> GetAll()
        {
            return reviewDictionary.Values;
        }


       



        public Review Find(int id)
        {
            var review = reviewDictionary.Values.SingleOrDefault(b => b.Id == id);
            return review;
        }



        public void Update(int id, Review review)
        {
            var Reviewpro = Find(id);

            Reviewpro.Description = review.Description;

            Reviewpro.Image = review.Image;
           

        }
        public void Delete(int id)
        {

            reviewDictionary.Remove(id);
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
