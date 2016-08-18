using System.Collections.Generic;
using Pokenet.Models.Common;

namespace Pokenet.Models.Berries
{
  public class BerryFlavor
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<FlavorBerryMap> Berries { get; set; }
    public NamedAPIResource ContestType { get; set; }
    public List<Name> Names { get; set; }
  }
}