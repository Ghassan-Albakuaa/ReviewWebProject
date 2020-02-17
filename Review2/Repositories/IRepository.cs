using Review2.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Review2.Repositories
{
 public   interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        ProductModel Find(int id);
        void Add(int id,T product);

        void Update(int id, T product);

        void Delete(int id);

        void Review(int id, T review);

        void Remove_Review(int id, T product);
    }
}
