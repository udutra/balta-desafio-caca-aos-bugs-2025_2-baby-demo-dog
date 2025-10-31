using BugStore.Data;
using BugStore.Handlers.Interfaces;
using BugStore.Models;
using BugStore.Requests.Orders;
using BugStore.Responses.Orders;
using Microsoft.EntityFrameworkCore;

namespace BugStore.Handlers.Orders;

public class OrderHandler(AppDbContext context) : IHandlerOrder{

    public async Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request,
        CancellationToken cancellationToken = default){
        try{
            var order = new Order(request.CustomerId, request.Customer, request.Lines);
            await context.Orders.AddAsync(order, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);

            return new CreateOrderResponse(order);
        }
        catch (DbUpdateException){
            return new CreateOrderResponse(null, 500,
                "Erro ao criar o pedido. ErroCod: OH0001");
        }
        catch (OperationCanceledException){
            return new CreateOrderResponse(null, 499, "Operação cancelada.");
        }
        catch (Exception){
            return new CreateOrderResponse(null, 500,
                "Erro inesperado. ErroCod: OH0001-GEN");
        }
    }

    public async Task<GetOrderByIdResponse> GetOrderByIdAsync(GetOrderByIdRequest request,
        CancellationToken cancellationToken = default){
        try{
            var order = await context.Orders
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);

            return order is null ?
                new GetOrderByIdResponse(null, 404, "Pedido não encontrado.")
                : new GetOrderByIdResponse(order);
        }
        catch (OperationCanceledException){
            return new GetOrderByIdResponse(null, 499, "Operação cancelada.");
        }
        catch{
            return new GetOrderByIdResponse(null, 500,
                "Ocorreu um erro ao buscar o pedido. ErroCod: OH0002");
        }
    }
}