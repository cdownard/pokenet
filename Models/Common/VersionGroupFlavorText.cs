namespace Pokenet.Models.Common
{
  public class VersionGroupFlavorText
  {
    public string Text { get; set; }
    public NamedAPIResource Language { get; set; }
    public NamedAPIResource VersionGroup { get; set; }
  }
}