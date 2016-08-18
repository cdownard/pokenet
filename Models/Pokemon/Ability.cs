using System.Collections.Generic;
using Pokenet.Models.Common;

namespace Pokenet.Models.Pokemon
{
  public class Ability
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsMainSeries { get; set; }
    public NamedAPIResource Generation { get; set; }
    public List<Name> Names { get; set; }
    public List<VerboseEffect> EffectEntries { get; set; }
    public List<AbilityEffectChange> EffectChanges { get; set; }
    public List<AbilityFlavorText> FlavorTextEntries { get; set; }
    public List<AbilityPokemon> Pokemon { get; set; }
  }
}
