using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RunningApp.Model;

public class Person : PageModel
{
    
    private int _id;
    private string _name;
    private string _phone;
    
    //get set metode til at sætte og hente variabler i klassen Person og tilgængelighed. 
    public int Id { get; set; }
    
    public string Navn { get; set; }
    
    public string Team { get; set; }
    
    //Konstruktør. Bruges til at lave objekter. 
    public Person(int id, string navn, string team)
    {
        Id = id;
        Navn = navn;
        Team = team;
    }

    //Konstruktør. Bruges til at lave objekter.
    public Person()
    {
        Id = 0;
        Navn = "";
        Team = "";
    }

    //Metode. Bruges til at udskrive. tostring 
    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(Navn)}: {Navn}, {nameof(Team)}: {Team}";
    }
    
}