namespace BugStore.Requests.Customers;

public class DeleteCustomerRequest(Guid id){
    public Guid Id { get; set; } = id;
}