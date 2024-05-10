using System.ComponentModel.DataAnnotations;


namespace Mochileiros.Models;
using System.Collections.Generic;
public class Travel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo Número de Viagem é obrigatório.")]
    [Range(1, int.MaxValue, ErrorMessage = "O Número de Viagem deve ser maior que zero.")]
    public int TravelNumber { get; set; }

    [Required(ErrorMessage = "O campo Destino é obrigatório.")]
    public string Destination { get; set; }
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "O campo Data de Ida é obrigatório.")]
    public DateTime StartDate { get; set; }
    
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "O campo Data de Volta é obrigatório.")]
    [DateGreaterThan("StartDate", ErrorMessage = "A Data de Volta deve ser posterior à Data de Ida.")]
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