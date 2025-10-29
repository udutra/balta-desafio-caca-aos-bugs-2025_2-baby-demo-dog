using BugStore.Models;

namespace BugStore.Responses.Products;

public class GetById(Product? data, int statusCode = Configuration.DefaultStatusCode,
    string message = "Produto encontrado com sucesso.") : Response<Product>(data, statusCode, message);