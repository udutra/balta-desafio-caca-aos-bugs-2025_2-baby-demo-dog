using System.Text.Json.Serialization;

namespace BugStore.Models;

public class Order{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public List<OrderLine> Lines { get; set; }

    private Order() { }

    public Order(Guid customerId, Customer customer, List<OrderLine> lines){
        Id = Guid.CreateVersion7();
        CustomerId = customerId;
        Customer = customer;
        Lines = lines;
        CreatedAt = DateTime.UtcNow;
    }
}