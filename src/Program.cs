using BugStore;
using BugStore.Common.Api;
using BugStore.Endpoints;

var builder = WebApplication.CreateBuilder(args);
builder.AddConfiguration();
builder.AddDataContexts();
builder.AddCrossOrigin();
builder.AddDocumentation();
builder.AddServices();


var app = builder.Build();

if(app.Environment.IsDevelopment())
    app.ConfigureDevEnvironment();

app.UseCors(Configuration.CorsPolicyName);
app.MapEndpoints();
app.Run();
/*
app.MapGet("/", () => "Hello World!");

app.MapGet("/v1/customers", async ([AsParameters] GetAllCustomersRequest request, CustomerHandler handler,
    CancellationToken cancellationToken) => {
    var response = await handler.GetAllCustomersAsync(request, cancellationToken);

    return StatusCode(response.StatusCode, response);

    //return response.IsSuccess ? StatusCode(response.StatusCode, response) Results.Ok(response.Data) : Results.NoContent();
});

app.MapGet("/v1/customers/{id:guid}", (Guid id) => "Hello World!");
app.MapPost("/v1/customers", () => "Hello World!");
app.MapPut("/v1/customers/{id:guid}", (Guid id) => "Hello World!");
app.MapDelete("/v1/customers/{id:guid}", (Guid id) => "Hello World!");

app.MapGet("/v1/products", () => "Hello World!");
app.MapGet("/v1/products/{id:guid}", (Guid id) => "Hello World!");
app.MapPost("/v1/products", () => "Hello World!");
app.MapPut("/v1/products/{id:guid}", (Guid id) => "Hello World!");
app.MapDelete("/v1/products/{id:guid}", (Guid id) => "Hello World!");

app.MapGet("/v1/orders/{id:guid}", (Guid id) => "Hello World!");
app.MapPost("/v1/orders", () => "Hello World!");
*/