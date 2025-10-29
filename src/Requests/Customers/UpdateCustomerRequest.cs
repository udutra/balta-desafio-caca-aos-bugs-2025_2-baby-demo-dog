namespace BugStore.Requests.Customers;

public class UpdateCustomerRequest(Guid id, string? name, string? email, string? phone, DateTime? birthDate){
    public Guid Id { get; set; } = id;
    public string? Name { get; set; } = name;
    public string? Email { get; set; } = email;
    public string? Phone { get; set; } = phone;
    public DateTime? BirthDate { get; set; } = birthDate;
}