using System.ComponentModel.DataAnnotations;
using Final.Utils;

namespace Final.Models;

public class Moto{

    public int Id { get; set; }

    [Display(Name="Marca")]
    public String Brand { get; set; }

    [Display(Name="Modelo")]
    public String Model { get; set; }
    [Display(Name="Centímetros cúbicos")]
    public int CubicCentimeters { get; set; }
    [Display(Name="Tipo")]
    public MotoType Type { get; set; }
    [Display(Name="Precio")]
    public double Price { get; set; }

    public virtual List<Accesory>? Accesories { get; set; }

}