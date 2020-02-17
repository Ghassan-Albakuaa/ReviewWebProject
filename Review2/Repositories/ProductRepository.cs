using Review2.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Review2.Repositories
{
    public class ProductRepository : IRepository<ProductModel>
    {
        
        public Dictionary<int, ProductModel> productDictionary;

        public ProductRepository()
        {
          productDictionary = new Dictionary<int, ProductModel>()
            {
                {1, new ProductModel(1, "Pac-Man", "Yellow eating monster")},
                {2, new ProductModel(2, "Gauntlet Legends", "Killing Game with Swords")},
                {3, new ProductModel(3, "DigDug", "Dig to China till it blows up")}

            };
        }

        public void Add(int id, ProductModel product)
        {
            productDictionary.Add(id, product);

           // return RedirectToAction(nameof(Index));
        }

        
        public IEnumerable<ProductModel> GetAll()
        {
            return productDictionary.Values;
        }

       
        public void Add(int id, ProductRepository product)
        {
            throw new NotImplementedException();
        }

     

        public ProductModel Find(int id)
        {
            var product = productDictionary.Values.SingleOrDefault(b => b.Id == id);
            return product;
        }

       

        public void Update(int id, ProductModel product)
        {
            var Product = Find(id);

            Product.Description = product.Description;
            Product.Name = product.Name;
            Product.Image = product.Image;
            Product.Review = product.Review;

        }
        public void Delete(int id)
        {
            var Product = Find(id);
            productDictionary.Remove(id);
        }
    }
}
