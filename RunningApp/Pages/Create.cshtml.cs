using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RunningApp.Model;
using RunningApp.Repo;

namespace RunningApp.Pages;

public class Create : PageModel
{
    private readonly List<Person> _allPersons;

    [BindProperty]
    public Person NewPerson { get; set; }

    public Create()
    {
        _allPersons = GetAll();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Generate a unique id for the new person
        int id = GenerateUniqueId();

        // Create the new person object
        var newPerson = new Person
        {
            Id = id,
            Navn = NewPerson.Navn,
            Team = NewPerson.Team
        };

        // Add the new person to the list
        _allPersons.Add(newPerson);

        // Additional logic if needed
        
        return RedirectToPage("Index"); // Redirect to the main listing page, adjust as necessary
    }

    // Method to generate a unique id
    private int GenerateUniqueId()
    {
        // Example: generate a random id
        return new Random().Next(1000, 9999);
    }

    // Method to get all persons (replace this with your actual implementation)
    private List<Person> GetAll()
    {
        return new List<Person>
        {
            new Person { Id = 1, Navn = "John Doe", Team = "Team A" },
            new Person { Id = 2, Navn = "Jane Doe", Team = "Team B" },
            new Person { Id = 3, Navn = "Jim Beam", Team = "Team A" },
            new Person { Id = 4, Navn = "Jill Valentine", Team = "Team C" },
            new Person { Id = 5, Navn = "Jake Blues", Team = "Team B" }
        };
    }
}