using GraphQL.Types;
using GraphQLTest.Api.Data;
using GraphQLTest.Api.GraphQL.Types;

namespace GraphQL.Api.GraphQL.Types
{
    public class ProductDbQuery : ObjectGraphType
    {   
        public ProductDbQuery(IProductDbRepository repo)
        {
            Field<ListGraphType<ProductType>>(
                "products",
                resolve: context => repo.GetProductsAsync()
            );
        }
    }
}