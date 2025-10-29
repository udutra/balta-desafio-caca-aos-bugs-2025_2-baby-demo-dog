using BugStore.Models;

namespace BugStore.Responses.Products;

public class Create(Product? data, int statusCode = 201, string message = "Produto criado com sucesso.")
    : Response<Product>(data, statusCode, message);