using Catalog.Api.Entities;
using MongoDB.Driver;

namespace Catalog.Api.Data
{
    public class CatalogContextSeed
    {

        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();

            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetSeedData());
            }
        }

        private static IEnumerable<Product> GetSeedData()
        {
            return new List<Product>()
            {
                new Product
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "IPhone X",
                    Summary="This phone is the company's biggest change",
                    Description= "Lore ipsum dolor sit amet",
                    ImageFIle="product-1.png",
                    Price = 950.00M,
                    Category  = "Smart Phone"
                },
                new Product
                {
                    Id = "602d21249e773f2a399b4f6",
                    Name = "Samsung 10,
                    Summary="This phone is the company's biggest change",
                    Description= "Lore ipsum dolor sit amet",
                    ImageFIle="product-2.png",
                    Price = 840.00M,
                    Category  = "Smart Phone"
                },
            };
        }
    }
}
