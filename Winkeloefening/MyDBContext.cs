using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Winkeloefening.Modellen;

namespace Winkeloefening
{
    internal class MyDBContext : DbContext
    {
        public DbSet<Categorie> Categorieen {  get; set; }

        public DbSet<Product> Products { get; set; }

        public void Start()
        {
            Categorie kc = new Categorie { Name = "Fruit" };
            Categorie kd = new Categorie { Name = "Tomaatachtige" };
            


            if (!Categorieen.Any())
            {
                
                Categorieen.Add(kc);
                Categorieen.Add(kd);

            }
            else
            {
                kc = Categorieen.First();
            }

            if(!Products.Any() ){

                Product product1 = new Product()
                {
                    Name = "Banaan",
                    Description = "Een gele, kromme banaan",
                    Categorie = kc
                };
                Product product2 = new Product()
                {
                    Name = "Tomaat",
                    Description = "Een rode, sappige tomaat",
                    Categorie = kd
                };

                Products.Add(product1);
                Products.Add(product2);
            }
            SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.Use();
            optionsBuilder.UseSqlServer(@"server=DESKTOP-LSB9S29\SQLEXPRESS;Database=Winkel;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=true");
            // base.OnConfiguring(optionsBuilder);
        }
    }
}
