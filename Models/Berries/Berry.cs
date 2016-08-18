using System.Collections.Generic;
using Pokenet.Models.Common; 

namespace Pokenet.Models.Berries
{
  public class Berry
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int GrowthTime { get; set; }
    public int MaxHarvest { get; set; }
    public int NaturalGiftPower { get; set; }
    public int Size { get; set; }
    public int Smoothness { get; set; }
    public int SoilDryness { get; set; }
    public NamedAPIResource Firmness { get; set; }
    public List<BerryFlavorMap> Flavors { get; set; }
    public NamedAPIResource Item { get; set; }
    public NamedAPIResource NaturalGiftType { get; set; }
  }
}