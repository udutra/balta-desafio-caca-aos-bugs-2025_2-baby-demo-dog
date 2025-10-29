using BugStore.Models;

namespace BugStore.Responses.Products;

public class CreateProductResponse(Product? data, int statusCode = 201, string message = "Produto criado com sucesso.")
    : Response<Product>(data, statusCode, message);