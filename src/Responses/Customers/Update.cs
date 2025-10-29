using BugStore.Models;

namespace BugStore.Responses.Customers;

public class Update(Customer? data, int statusCode = Configuration.DefaultStatusCode,
    string message = "Cliente atualizado com sucesso.")
    : Response<Customer>(data, statusCode, message);