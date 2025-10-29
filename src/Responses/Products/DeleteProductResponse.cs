using BugStore.Models;

namespace BugStore.Responses.Products;

public class DeleteProductResponse(Product? data, int statusCode = Configuration.DefaultStatusCode,
    string message = "Produto removido com sucesso.")
    : Response<Product>(data, statusCode, message);