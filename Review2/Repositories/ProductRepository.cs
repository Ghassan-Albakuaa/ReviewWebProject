using Review2.Models;
using System;
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

        public ProductModel Find(int id)
        {

            var product = productDictionary.Values.SingleOrDefault(b => b.Id == id);
            return product;
        }

        public IEnumerable<ProductModel> GetAll()
        {
            return productDictionary.Values;
        }

        IEnumerable<ProductModel> IRepository<ProductModel>.Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
