namespace BugStore.Requests.Products;

public class Update{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? Slug { get; set; }
    public decimal Price { get; set; }
}