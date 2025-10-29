namespace BugStore.Models;

public class Order(Guid customerId, Customer customer, DateTime createdAt, DateTime updatedAt){
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public Guid CustomerId { get; set; } = customerId;
    public Customer Customer { get; set; } = customer;
    public DateTime CreatedAt { get; set; } = createdAt;
    public DateTime UpdatedAt { get; set; } = updatedAt;
    public List<OrderLine> Lines { get; set; } = [];
}