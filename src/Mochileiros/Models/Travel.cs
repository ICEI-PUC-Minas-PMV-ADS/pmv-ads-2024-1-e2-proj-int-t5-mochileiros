using System.ComponentModel.DataAnnotations;

namespace Mochileiros.Models;
using System.Collections.Generic;
public class Travel
{
    public int Id { get; set; }
    public int TravelNumber { get; set; }
    public string? Destination { get; set; }
    [DataType(DataType.Date)]
    public DateTime StartDate { get; set; }
    [DataType(DataType.Date)]
    public DateTime EndDate { get; set; }
    public string? Image { get; set; }
    public ICollection<Expense>? Expenses { get; set; }
    public int? GroupId { get; set; }
    public Group? Group { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}
