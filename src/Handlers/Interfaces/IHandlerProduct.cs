using BugStore.Requests.Products;
using BugStore.Responses.Products;

namespace BugStore.Handlers.Interfaces;

public interface IHandlerProduct{
    Task<CreateProductResponse> CreateProductAsync(CreateProductRequest request,
        CancellationToken cancellationToken = default);
    Task<GetProductByIdResponse> GetProductByIdAsync(GetProductByIdRequest request,
        CancellationToken cancellationToken = default);
    Task<GetAllProductsResponse> GetAllProductsAsync(GetAllProductsRequest request,
        CancellationToken cancellationToken = default);
    Task<DeleteProductResponse> DeleteProductAsync(DeleteProductRequest request,
        CancellationToken cancellationToken = default);
    Task<UpdateProductResponse> UpdateProductAsync(UpdateProductRequest request,
        CancellationToken cancellationToken = default);

}