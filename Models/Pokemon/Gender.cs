using System.Collections.Generic;
using Pokenet.Models.Common;

namespace Pokenet.Models.Pokemon
{
  public class Gender
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<PokemonSpeciesGender> PokemonSpeciesDetails { get; set; }
    public List<NamedAPIResource> RequiredForEvolution { get; set; }
  }
}