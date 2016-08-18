using Pokenet.Models.Common;

namespace Pokenet.Models.Pokemon
{
  public class AbilityPokemon
  {
    public bool IsHidden { get; set; }
    public int Slot { get; set; }
    public NamedAPIResource Pokemon { get; set; }
  }
}