
using System.ComponentModel.DataAnnotations;

namespace Mochileiros.Models;

using System.Collections.Generic;

public class Group
{
    public int Id { get; set; }
    public List<User> Users { get; set; }
    public int NumberOfUsers { get; set; }
    public int TravelId { get; set; }
    public Travel Travel { get; set; }
}

