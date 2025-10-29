using BugStore.Models;

namespace BugStore.Responses.Products;

public class UpdateProductResponse(Product? data, int statusCode = Configuration.DefaultStatusCode,
    string message = "Produto atualizado com sucesso.") : Response<Product>(data, statusCode, message);