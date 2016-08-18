using System.Collections.Generic;

namespace Pokenet.Models.Common
{
  public class VersionEncounterDetail
  {
    public NamedAPIResource Version { get; set; }
    public int MaxChance { get; set; }
    public List<Encounter> EncounterDetails { get; set; }
  }
}