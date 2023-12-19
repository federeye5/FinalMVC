using Final.Models;

namespace Final.ViewModels;

public class AccesorySearchViewModel
{
    public List<Accesory> Accesories {get; set;} = new List<Accesory>();

    public string? NameFilter { get; set; }
}