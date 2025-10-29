using BugStore.Models;

namespace BugStore.Responses.Customers;

public class Delete(Customer? data = null, int statusCode = Configuration.DefaultStatusCode,
    string? message = "Cliente removido com sucesso.")
    : Response<Customer>(data, statusCode, message);