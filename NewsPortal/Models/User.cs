using System.ComponentModel.DataAnnotations;
using System.Data;

namespace NewsPortal.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public int? RoleId { get; set; }
    public Role Role { get; set; }


}
