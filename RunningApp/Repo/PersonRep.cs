using RunningApp.Model;

namespace RunningApp.Repo;

public class PersonRep
{
    private readonly List<Person> _persons;

    public PersonRep()
    {
        _persons = new List<Person>
        {
            new Person { Id = 1, Navn = "John Doe", Team = "Team A" },
            new Person { Id = 2, Navn = "Jane Doe", Team = "Team B" },
            new Person { Id = 3, Navn = "Jim Beam", Team = "Team A" },
            new Person { Id = 4, Navn = "Jill Valentine", Team = "Team C" },
            new Person { Id = 5, Navn = "Jake Blues", Team = "Team B" }
        };
    }

    /*
     * CRUD metoder
     */
    public List<Person> GetAll()
    {
        return new List<Person>(_persons );
    }
    
    public void Add(Person person)
    {
        _persons.Add(person);
    }

    public void Remove(Person person)
    {
        _persons.Remove(person);
    }
    
    public List<Person> SearchByName(string navn, string team)
    {
        return _persons.Where(p => p.Navn.ToLower().Equals(navn.ToLower())).ToList();
    }
    public List<Person> SearchByTeam(string navn, string team)
    {
        return _persons.Where(p => p.Navn.ToLower().Equals(navn.ToLower())).ToList();
    }
    
    
    public List<Person> SearchByName(string searchTerm)
    {
        searchTerm = searchTerm?.ToLower() ?? string.Empty;
        return _persons.Where(p => p.Navn.ToLower().Contains(searchTerm) ||
                                   p.Team.ToLower().Contains(searchTerm)).ToList();
    }
    
    
    public List<Person> SearchByTeam(string searchTerm)
    {
        searchTerm = searchTerm?.ToLower() ?? string.Empty;
        return _persons.Where(p => p.Navn.ToLower().Contains(searchTerm) ||
                                   p.Team.ToLower().Contains(searchTerm)).ToList();
    }
    
    

}