using System.ComponentModel.DataAnnotations;

namespace Mochileiros.Models;

public class Expense
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public decimal Value { get; set; }
    public string? Type { get; set; }
    public string? Name { get; set; }
    public DateTime Date { get; set; }
    public int TravelID { get; set; }
    public Travel? Travel { get; set; }
}

