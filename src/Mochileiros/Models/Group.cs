
using System.ComponentModel.DataAnnotations;

namespace Mochileiros.Models;

using System.Collections.Generic;

public class Participant
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
    }


public class Group
{
    public int Id { get; set; }
    public List<Participant> Participants { get; set; }
    public int NumberOfUsers { get; set; }
    public int TravelId { get; set; }
    public Travel Travel { get; set; }
}

