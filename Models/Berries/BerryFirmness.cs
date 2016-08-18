using System.Collections.Generic;
using Pokenet.Models.Common;

namespace Pokenet.Models.Berries
{
  public class BerryFirmness
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<NamedAPIResource> Berries { get; set; }
    public List<Name> Names { get; set; }
  }
}