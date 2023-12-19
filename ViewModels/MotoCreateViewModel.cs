using Final.Models;

namespace Final.ViewModels;

public class MotoCreateViewModel
{
    public Moto Moto {get; set;}

    public List<int>? SelectedAccesories {get; set;} = new List<int>();

    public List<Accesory>? Accesories {get; set;} 
}