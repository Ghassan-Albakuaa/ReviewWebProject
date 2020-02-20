using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Review2.Models
{


    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MyProductDB2;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().HasData(
                new ProductModel
                {
                    Id = 1,
                    Name = "Pac-Man",
                    Description = "Yellow fruit-eating monster",
                    Review = "I bought this arcade game, now I hate ghosts!",
                    Image = "/img/pacman.jpg" ,
                    ReviewId = 1
                },
                new ProductModel
                {
                    Id = 2,
                    Name = "Gauntlet Legends",
                    Description = "Save the Realms from certain doom",
                    Review = "Wtf I love this game?",
                    Image = "/img/GauntletLegends.jpg",
                     ReviewId = 1
                },
                new ProductModel
                {
                    Id = 3,
                    Name = "DigDug",
                    Description = "Dig and dug",
                    Review = "Being inflated till you explode has got to hurt!",
                    Image = "/img/digdug.jpg" ,
                    ReviewId = 3
                }
                );



            modelBuilder.Entity<Review>().HasData(
                new Review()
                {
                    Id = 1,
                    Description = "hlkjhlkjhkjlh",
                    Name = "ghassan"
                },
                  new Review()
                  {
                      Id = 2,
                      Description = "hlkjhlkjhkjlh",
                    Name = "ghassan"
                  },

                new Review()
                {
                    Id = 3,
                    Description = "nbgkljglkjghlkjhl",
                     Name = "ali"
                });

            base.OnModelCreating(modelBuilder);

            //  base.OnConfiguring(modelBuilder);
        }
    }
}

