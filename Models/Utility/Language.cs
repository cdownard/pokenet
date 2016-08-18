using System.Collections.Generic;
using Pokenet.Models.Common;

namespace Pokenet.Models.Utility
{
  public class Language
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Official { get; set; }
    public string ISO639 { get; set; }
    public string IS3166 { get; set; }
    public List<Name> Names { get; set; }
  }
}
