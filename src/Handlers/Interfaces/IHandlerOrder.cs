using BugStore.Requests.Orders;
using BugStore.Responses.Orders;

namespace BugStore.Handlers.Interfaces;

public interface IHandlerOrder{
    Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request,
        CancellationToken cancellationToken = default);
    Task<GetOrderByIdResponse> GetOrderByIdAsync(GetOrderByIdRequest request,
        CancellationToken cancellationToken = default);
}