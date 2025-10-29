using BugStore.Models;

namespace BugStore.Responses.Products;

public class GetAllProductResponse : PagedResponse<List<Product>>
{
    public GetAllProductResponse(List<Product>? data, int totalCount, int currentPage, int pageSize)
        : base(data, totalCount, currentPage, pageSize)
    {
    }

    public GetAllProductResponse(List<Product>? data, int statusCode = Configuration.DefaultStatusCode, string? message = null)
        : base(data, statusCode, message)
    {
    }
}