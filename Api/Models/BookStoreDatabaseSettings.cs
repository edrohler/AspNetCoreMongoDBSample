using System.ComponentModel.DataAnnotations;

namespace Api.Models;

public class BookStoreDatabaseSettings
{
    [Required]
    public required string BooksCollectionName { get; set; }
    [Required]
    public required string ConnectionString { get; set; }
    [Required]
    public required string DatabaseName { get; set; }
}