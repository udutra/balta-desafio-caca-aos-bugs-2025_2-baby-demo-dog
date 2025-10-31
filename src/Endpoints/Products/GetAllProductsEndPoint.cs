using BugStore.Common.Api;
using BugStore.Handlers.Interfaces;
using BugStore.Requests.Products;
using BugStore.Responses.Products;
using Microsoft.AspNetCore.Mvc;

namespace BugStore.Endpoints.Products;

public class GetAllProductsEndPoint : IEndpoint{
    public static void Map(IEndpointRouteBuilder app)
        => app.MapGet("", HandleAsync)
            .WithName("Products: GetAll")
            .WithSummary("Busca todos os produtos")
            .WithDescription("Busca todos os produtos")
            .WithOrder(3)
            .Produces<GetAllProductsResponse>();

    private static async Task<IResult> HandleAsync(IHandlerProduct handler,
        [FromQuery] int pageNumber = Configuration.DefaultPageNumber,
        [FromQuery] int pageSize = Configuration.DefaultPageSize){

        var request = new GetAllProductsRequest(pageNumber, pageSize);

        var result = await handler.GetAllProductsAsync(request);
        return result.IsSuccess
            ? TypedResults.Ok(result)
            : TypedResults.BadRequest(result);
    }
}