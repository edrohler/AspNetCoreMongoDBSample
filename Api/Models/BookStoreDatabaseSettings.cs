namespace Api.Models;

public class BookStoreDatabaseSettings
{
    public string BooksCollectionName { get; set; } = null!;
    public string ConnectionString { get; set; } = null!;
    public string DatabaseName { get; set; } = null!;
}