using System.Collections.Generic;
using Pokenet.Models.Common;

namespace Pokenet.Models.Pokemon
{
  public class AbilityEffectChange
  {
    public List<Effect> EffectEntries { get; set; }
    public NamedAPIResource VersionGroup { get; set; }
  }
}