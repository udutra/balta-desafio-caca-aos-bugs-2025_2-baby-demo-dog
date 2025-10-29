namespace BugStore.Models;

public class Product(string title, string description, string slug, decimal price){
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public string Title { get; set; } = title;
    public string Description { get; set; } = description;
    public string Slug { get; set; } = slug;
    public decimal Price { get; set; } = price;
}