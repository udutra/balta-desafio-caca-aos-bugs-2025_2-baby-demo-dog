namespace BugStore.Models;

public class Customer(string name, string email, string phone, DateTime birthDate){
    public Guid Id { get;  set; } = Guid.CreateVersion7();
    public string Name { get; set; } = name;
    public string Email { get; set; } = email;
    public string Phone { get; set; } = phone;
    public DateTime BirthDate { get; set; } = birthDate;
}