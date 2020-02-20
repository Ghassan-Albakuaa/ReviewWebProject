using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Review2.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Review { get; set; }
        public ProductModel()
        {

        }

        public ProductModel(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public ProductModel(int id, string name, string description, string image, string review)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Review = review;
        }
        public ProductModel Find(int id)
        {
            ProductModel proModel = new ProductModel();
            Id = id;
            return proModel;
        }

        public static implicit operator DbSet<object>(ProductModel v)
        {
            throw new NotImplementedException();
        }
    }
}