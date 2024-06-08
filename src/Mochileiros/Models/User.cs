using System.ComponentModel.DataAnnotations;

namespace Mochileiros.Models;
using System.Collections.Generic;

public class User
{
    public int Id { get; set; }
    [Required(ErrorMessage ="Obrigatório Informar o nome!")]
    public string Name { get; set; }
    public string Email { get; set; }
    [Required(ErrorMessage = "Obrigatório Informar a Username!")]
    public string Nickname { get; set; }
    
    [Required(ErrorMessage = "Obrigatório Informar a senha!")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    public List<Group>? Groups { get; set; }

    public List<Travel>? Travels { get; set; }
}

