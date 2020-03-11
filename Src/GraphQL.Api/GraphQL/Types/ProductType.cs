using GraphQL.Types;
using GraphQLTest.Api.Data.Entities;

namespace GraphQLTest.Api.GraphQL.Types
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(product => product.Id);
            Field(product => product.Name);
            Field(product => product.Description);
        }
    }
}