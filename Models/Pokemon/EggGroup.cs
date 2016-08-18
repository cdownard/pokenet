using System.Collections.Generic;
using Pokenet.Models.Common;

namespace Pokenet.Models.Pokemon
{
  public class EggGroup
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Name> Names { get; set; }
    public List<NamedAPIResource> PokemonSpecies { get; set; }
  }
}