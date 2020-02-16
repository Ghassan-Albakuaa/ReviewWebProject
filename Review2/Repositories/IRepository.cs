using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Review2.Repositories
{
    interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
