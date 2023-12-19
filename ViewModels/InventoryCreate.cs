using Final.Models;

namespace Final.ViewModels;

public class InventoryCreate{

    public int AgencyId { get; set;}

    public List<Moto>? Motos { get; set;}

    public Inventory Inventory  { get; set;} = new();
}