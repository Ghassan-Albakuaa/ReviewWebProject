using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Review2.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public virtual ICollection<ProductModel> Product { get; set; }
        public Review()
        {

        }

       
        public Review(int id, string description, string image)
        {
            Id = id;
        
            Description = description;
            Image = image;
          
        }
        public Review( string description, string image)
        {
           

            Description = description;
            Image = image;

        }
        public Review Find(int id)
        {
            Review proModel = new Review();
            Id = id;
            return proModel;
        }




    }
}
