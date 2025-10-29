using BugStore.Models;

namespace BugStore.Responses.Orders;

public class GetById(Order? data, int statusCode = Configuration.DefaultStatusCode,
    string message = "Pedido encontrado com sucesso.")
    : Response<Order>(data, statusCode, message);