using BugStore.Common.Api;
using BugStore.Handlers.Interfaces;
using BugStore.Requests.Customers;
using BugStore.Responses.Customers;
using Microsoft.AspNetCore.Mvc;

namespace BugStore.Endpoints.Customers;

public class GetAllCustomerEndPoint : IEndpoint{
    public static void Map(IEndpointRouteBuilder app)
        => app.MapGet("", HandleAsync)
            .WithName("Customer: GetAll")
            .WithSummary("Busca todos os clientes")
            .WithDescription("Busca todos os clientes")
            .WithOrder(3)
            .Produces<GetAllCustomersResponse>();

    private static async Task<IResult> HandleAsync(IHandlerCustomer handler,
        [FromQuery] int pageNumber = Configuration.DefaultPageNumber,
        [FromQuery] int pageSize = Configuration.DefaultPageSize){

        var request = new GetAllCustomersRequest(pageNumber, pageSize);

        var result = await handler.GetAllCustomersAsync(request);
        return result.IsSuccess
            ? TypedResults.Ok(result)
            : TypedResults.BadRequest(result);
    }
}