namespace BugStore.Requests;

public abstract class PagedRequest{
    public int PageNumber { get; set; } = Configuration.DefaultPageNumber;
    public int PageSize { get; set; } = Configuration.DefaultPageSize;
}