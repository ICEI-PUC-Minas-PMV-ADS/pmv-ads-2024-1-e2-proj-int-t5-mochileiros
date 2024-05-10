using System.ComponentModel.DataAnnotations;


namespace Mochileiros.Models;
using System.Collections.Generic;
public class Travel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo N�mero de Viagem � obrigat�rio.")]
    [Range(1, int.MaxValue, ErrorMessage = "O N�mero de Viagem deve ser maior que zero.")]
    public int TravelNumber { get; set; }

    [Required(ErrorMessage = "O campo Destino � obrigat�rio.")]
    public string Destination { get; set; }
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "O campo Data de Ida � obrigat�rio.")]
    public DateTime StartDate { get; set; }
    
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "O campo Data de Volta � obrigat�rio.")]
    [DateGreaterThan("StartDate", ErrorMessage = "A Data de Volta deve ser posterior � Data de Ida.")]
    public DateTime EndDate { get; set; }


    public string Image { get; set; }
    public ICollection<Expense>? Expenses { get; set; }
    public int? GroupId { get; set; }
    public Group? Group { get; set; }
    public int? UserId { get; set; }
    public User? User { get; set; }
}
public class DateGreaterThanAttribute : ValidationAttribute
{
    private readonly string _comparisonProperty;

    public DateGreaterThanAttribute(string comparisonProperty)
    {
        _comparisonProperty = comparisonProperty;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var property = validationContext.ObjectType.GetProperty(_comparisonProperty);

        if (property == null)
        {
            throw new ArgumentException("Property with this name not found");
        }

        var comparisonValue = (DateTime)property.GetValue(validationContext.ObjectInstance);
        var currentValue = (DateTime)value;

        if (currentValue <= comparisonValue)
        {
            return new ValidationResult(ErrorMessage ?? $"The {validationContext.DisplayName} must be greater than {_comparisonProperty}.");
        }

        return ValidationResult.Success;
    }
}