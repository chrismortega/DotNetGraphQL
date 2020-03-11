using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQLTest.Api.Data.Entities;

namespace GraphQLTest.Api.Data
{
    public interface IProductDbRepository
    {
        Task<List<Product>> GetProductsAsync();
    }
}