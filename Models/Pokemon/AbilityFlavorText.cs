using Pokenet.Models.Common;

namespace Pokenet.Models.Pokemon
{
  public class AbilityFlavorText
  {
    public string FlavorText { get; set; }
    public NamedAPIResource Language { get; set; }
    public NamedAPIResource VersionGroup { get; set; }
  }
}