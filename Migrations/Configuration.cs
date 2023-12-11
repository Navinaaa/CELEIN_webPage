namespace CELEIN_webPage.Migrations
{
    using CELEIN_webPage.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CELEIN_webPage.Data.CELEIN_webPageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CELEIN_webPage.Data.CELEIN_webPageContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var categories = new List<Category>
            {
                new Category{Name="Conditioners"},
                new Category{Name="Developers/Activators"},
                new Category{Name="Hair Colors"},
                new Category{Name="Hair Keratin"},
                new Category{Name="Hair Styling"},
                new Category{Name="Masks"},
                new Category{Name="Serums/Oils"},
                new Category{Name="Shampoos"}
            };
            categories.ForEach(c=>context.Categories.AddOrUpdate(p=>p.Name,c));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product{Name="PROFESSIONAL HAIR COLOR CREAM – IRISEE",Description="A cutting-edge formulation based on Plex Technology that enhances the cosmetic result of the coloring by reinforcing the hair fiber. Thanks to the use of the balanced pigment calculation system, it ensures excellent color rendering, total coverage of white hair, maximum reliability and stability of reflections. Enriched with Keratin and Ceramides, it gives the hair a healthy look, giving it softness and extraordinary shine.",Price=100,CategoryID=categories.Single(c=>c.Name=="Shampoos").ID},
                new Product{Name="PROFESSIONAL HAIR COLOR CREAM – SUPERLIGHTENERS",Description="A cutting-edge formulation based on Plex Technology that enhances the cosmetic result of the coloring by reinforcing the hair fiber. Thanks to the use of the balanced pigment calculation system, it ensures excellent color rendering, total coverage of white hair, maximum reliability and stability of reflections. Enriched with Keratin and Ceramides, it gives the hair a healthy look, giving it softness and extraordinary shine.",Price=100,CategoryID=categories.Single(c=>c.Name=="Shampoos").ID}
            };
            products.ForEach(c=>context.Products.AddOrUpdate(p=>p.Name,c));
            context.SaveChanges();
        }
    }
}
