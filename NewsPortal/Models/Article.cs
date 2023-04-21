using System.ComponentModel.DataAnnotations;

namespace NewsPortal.Models;

[DisplayColumn("Новости")]
public class Article
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Заголовок")]
    [Required]
    public string? Name { get; set; }
    [Display(Name = "текст новости")]
    public string? FullText { get; set; }

    public int CategoryId { get; set; }
    public virtual Category? Category { get; set; }
}
