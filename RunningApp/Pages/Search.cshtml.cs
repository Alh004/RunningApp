using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RunningApp.Repo;

namespace RunningApp.Model;

public class Search : PageModel
{
    private readonly PersonRep _personRepo;

    public Search(PersonRep personRepo)
    {
        _personRepo = personRepo;
    }
    [BindProperty(SupportsGet = true)]
    public string SearchTerm { get; set; }

    public List<Person> Results { get; set; }

    public void OnGet()
    {
        if (!string.IsNullOrEmpty(SearchTerm))
        {
            Results = _personRepo.SearchByName(SearchTerm);
            Results= Results.Distinct().ToList();
            Results = _personRepo.SearchByTeam(SearchTerm);
            Results = Results.Distinct().ToList();
        }
        else
        {
            Results = _personRepo.GetAll();
        }
    }
    
    
}