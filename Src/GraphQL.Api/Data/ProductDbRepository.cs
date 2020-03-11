using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQLTest.Api.Data.Entities;

namespace GraphQLTest.Api.Data
{
    public class ProductDbRepository : IProductDbRepository
    {
        public Task<List<Product>> GetProductsAsync()
        {
            return Task.FromResult(new List<Product>() {
                new Product() 
                {
                    Id = 1,
                    Name = "Ball",
                    Description = "A red ball"
                },
                new Product() 
                {
                    Id = 2,
                    Name = "Game System",
                    Description = "Plays video games"
                }
            });
        }
    }
}