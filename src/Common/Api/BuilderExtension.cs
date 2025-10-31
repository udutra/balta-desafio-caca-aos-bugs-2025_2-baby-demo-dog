using BugStore.Data;
using BugStore.Handlers.Customers;
using BugStore.Handlers.Interfaces;
using BugStore.Handlers.Orders;
using BugStore.Handlers.Products;
using Microsoft.EntityFrameworkCore;

namespace BugStore.Common.Api;

public static class BuilderExtension{
    public static void AddConfiguration(this WebApplicationBuilder builder){
        Configuration.ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? string.Empty;
        Configuration.BackendUrl = builder.Configuration.GetValue<string>("BackendUrl") ?? string.Empty;

    }

    public static void AddDocumentation(this WebApplicationBuilder builder){
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(x=> x.CustomSchemaIds(n => n.FullName));
    }

    public static void AddDataContexts(this WebApplicationBuilder builder){
        builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlite(Configuration.ConnectionString));
    }

    public static void AddServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IHandlerCustomer, CustomerHandler>();
        builder.Services.AddScoped<IHandlerOrder, OrderHandler>();
        builder.Services.AddScoped<IHandlerProduct, ProductHandler>();

    }
    public static void AddCrossOrigin(this WebApplicationBuilder builder)
    {
        builder.Services.AddCors(options => options.AddPolicy(
            Configuration.CorsPolicyName,
            policy => policy
                .WithOrigins([
                    Configuration.BackendUrl
                ])
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials()
        ));
    }
}