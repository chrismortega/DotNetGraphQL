using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using GraphQLTest.Api.Data;
using GraphQL;
using GraphQLTest.Api.GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;

namespace GraphQLTest.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductDbRepository, ProductDbRepository>();
            services.AddScoped<IDependencyResolver>(provider => new FuncDependencyResolver(provider.GetRequiredService));
            services.AddScoped<ProductSchema>();
            services.AddGraphQL(options => options.ExposeExceptions = true)
                .AddGraphTypes(ServiceLifetime.Scoped);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseGraphQL<ProductSchema>();
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions());
        }
    }
}
