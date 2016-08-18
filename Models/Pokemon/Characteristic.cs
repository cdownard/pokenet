using System.Collections.Generic;
using Pokenet.Models.Common;

namespace Pokenet.Models.Pokemon
{
  public class Characteristic
  {
    public int Id { get; set; }
    public int GeneModulo { get; set; }
    public List<int> PossibleValues { get; set; }
    public List<Description> Descriptions { get; set; }
  }
}