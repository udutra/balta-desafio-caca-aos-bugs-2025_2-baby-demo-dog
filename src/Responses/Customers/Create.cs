using BugStore.Models;

namespace BugStore.Responses.Customers;

public class Create(Customer? data, int statusCode = Configuration.DefaultStatusCode,
    string message = "Cliente criado com sucesso.") : Response<Customer>(data, statusCode, message);