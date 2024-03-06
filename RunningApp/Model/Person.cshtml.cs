using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RunningApp.Model;

public class Person : PageModel
{
    public int Id { get; set; }
    public string Navn { get; set; }
    public string Team { get; set; }
    
    // Constructor with parameters
    public Person(int id, string navn, string team)
    {
        Id = id;
        Navn = navn;
        Team = team;
    }
   
    // Parameterless constructor
    public Person()
    {
        Id = 0;
        Navn = "";
        Team = "";
    }

    // Override ToString method for custom string representation
    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(Navn)}: {Navn}, {nameof(Team)}: {Team}";
    }
}