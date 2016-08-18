using System.Collections.Generic;

namespace Pokenet.Models.Common
{
  public class Encounter
  {
    public int MinLevel { get; set; }
    public int MaxLevel { get; set; }
    public List<NamedAPIResource> ConditionValues { get; set; }
    public int Chance { get; set; }
    public NamedAPIResource Method { get; set; }
  }
}
