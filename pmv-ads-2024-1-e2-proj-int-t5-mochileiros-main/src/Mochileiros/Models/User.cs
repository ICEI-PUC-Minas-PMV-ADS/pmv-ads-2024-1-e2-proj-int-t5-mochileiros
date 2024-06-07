using System.ComponentModel.DataAnnotations;

namespace Mochileiros.Models;
using System.Collections.Generic;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Nickname { get; set; }
    public string? Image { get; set; }
    public string Password { get; set; }
    public List<Group>? Groups { get; set; }

    public List<Travel>? Travels { get; set; }
}
