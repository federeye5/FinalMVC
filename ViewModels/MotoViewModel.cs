using Final.Models;

namespace Final.ViewModels;

public class MotoViewModel{

    public List<Moto> Motos { get; set;}

    public string? NameFilter { get; set; }

    public Moto Moto { get; set;} = new();

}