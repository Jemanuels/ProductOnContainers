using Microsoft.EntityFrameworkCore;
using ProductCatalogApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogApi.Data
{
    public class CatalogSeed
    {
        public static async Task SeedAsync(CatalogContext context)
        {
            context.Database.Migrate();
            if (!context.CatalogBrands.Any())
            {
                context.CatalogBrands.AddRange(GetPreconfiguredCatalogBrands());
                await context.SaveChangesAsync();
            }
            if (!context.CatalogTypes.Any())
            {
                context.CatalogTypes.AddRange(GetPreconfiguredCatalogTypes());
                await context.SaveChangesAsync();

            }
            if (!context.CatalogItems.Any())
            {
                context.CatalogItems.AddRange(GetPreconfiguredCatalogItems());
                await context.SaveChangesAsync();
            }


        }

        private static IEnumerable<CatalogItem> GetPreconfiguredCatalogItems()
        {
            return new List<CatalogItem>()
            {
                new CatalogItem() { CatalogTypeId=2,CatalogBrandId=3, Description = "shoes for next century", Name = "world star", Price = 199.5m, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/1" },
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=2, Description = "will make you world champions", Name = "white line", Price= 88.50m, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/2" },
                new CatalogItem() { CatalogTypeId=2,CatalogBrandId=3, Description = "you have already won gold medal", Name = "prism white shoes", Price = 129, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/3" },
                new CatalogItem() { CatalogTypeId=2,CatalogBrandId=2, Description = "olympic runner", Name = "foundation hitech", Price = 12, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/4" },
                new CatalogItem() { CatalogTypeId=2,CatalogBrandId=1, Description = "roslyn red sheet", Name = "roslyn white", Price = 188.5m, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/5" },
                new CatalogItem() { CatalogTypeId=2,CatalogBrandId=2, Description = "lala land", Name = "blue star", Price = 112, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/6" },
                new CatalogItem() { CatalogTypeId=2,CatalogBrandId=1, Description = "high in the sky", Name = "roslyn green", Price = 212, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/7"  },
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=1, Description = "light as carbon", Name = "deep purple", Price = 238.5m, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/8" },
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=2, Description = "high jumper", Name = "addidas<white> running", Price = 129, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/9" },
                new CatalogItem() { CatalogTypeId=2,CatalogBrandId=3, Description = "dunker", Name = "elequent", Price = 12, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/10" },
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=2, Description = "all round", Name = "inredeible", Price = 248.5m, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/11" },
                new CatalogItem() { CatalogTypeId=2,CatalogBrandId=1, Description = "pricesless", Name = "london sky", Price = 412, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/12" },
                new CatalogItem() { CatalogTypeId=3,CatalogBrandId=3, Description = "tennis star", Name = "elequent", Price = 123, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/13" },
                new CatalogItem() { CatalogTypeId=3,CatalogBrandId=2, Description = "wimbeldon", Name = "london star", Price = 218.5m, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/14" },
                new CatalogItem() { CatalogTypeId=3,CatalogBrandId=1, Description = "rolan garros", Name = "paris blues", Price = 312, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/15" }

            };
        }

        private static IEnumerable<CatalogType> GetPreconfiguredCatalogTypes()
        {
            return new List<CatalogType>()
            {
                new CatalogType() { Type = "Running"},
                new CatalogType() { Type = "Basketball" },
                new CatalogType() { Type = "Tennis" },

            };
        }

        private static IEnumerable<CatalogBrand> GetPreconfiguredCatalogBrands()
        {
            return new List<CatalogBrand>()
            {
                new CatalogBrand() { Brand = "Addidas"},
                new CatalogBrand() { Brand = "Puma"},
                new CatalogBrand() { Brand = "Slazenger"}
            };
        }
    }
}
