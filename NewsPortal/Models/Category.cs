using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace NewsPortal.Models;


[DisplayColumn("Категория")]
public class Category
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Заголовок")]
    [Required]
    public string? Name { get; set; }

    public List<Article>? Articles { get; set; }
}
