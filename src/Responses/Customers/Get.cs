using BugStore.Models;

namespace BugStore.Responses.Customers;

public class Get : PagedResponse<List<Customer>>
{
    public Get(List<Customer>? data, int totalCount, int currentPage, int pageSize)
        : base(data, totalCount, currentPage, pageSize)
    {
    }

    public Get(List<Customer>? data, int statusCode = Configuration.DefaultStatusCode,
        string message = "Lista de clientes retornada com sucesso.")
        : base(data, statusCode, message)
    {
    }
}