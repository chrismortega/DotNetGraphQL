using GraphQL;
using GraphQL.Api.GraphQL.Types;
using GraphQL.Types;

namespace GraphQLTest.Api.GraphQL
{
    public class ProductSchema : Schema
    {
        public ProductSchema(IDependencyResolver resolver)
        {
            Query = resolver.Resolve<ProductDbQuery>();
        }
    }
}