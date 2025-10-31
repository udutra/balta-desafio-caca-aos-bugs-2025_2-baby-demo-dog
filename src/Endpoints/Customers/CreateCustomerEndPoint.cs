using BugStore.Common.Api;
using BugStore.Handlers.Customers;
using BugStore.Requests.Customers;
using BugStore.Responses.Customers;

namespace BugStore.Endpoints.Customers;

public class CreateCustomerEndPoint: IEndpoint
{
    public static void Map(IEndpointRouteBuilder app) => app.MapPost("", HandleAsync)
        .WithName("Categories: Create")
        .WithSummary("Cria uma nova Categoria")
        .WithDescription("Cria uma nova Categoria")
        .WithOrder(1)
        .Produces<CreateCustomerResponse>();

    private static async Task<IResult> HandleAsync(CustomerHandler handler, CreateCustomerRequest request,
        CancellationToken cancellationToken){

        var response = await handler.CreateCustomerAsync(request, cancellationToken);

        return response.IsSuccess
            ? TypedResults.Created($"/{response.Data?.Id}", response)
            : TypedResults.BadRequest(response.Data);
    }
}