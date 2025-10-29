namespace BugStore.Models;

public class Order(Guid customerId, Customer customer, List<OrderLine> lines){
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public Guid CustomerId { get; set; } = customerId;
    public Customer Customer { get; set; } = customer;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public List<OrderLine> Lines { get; set; } = lines;
}