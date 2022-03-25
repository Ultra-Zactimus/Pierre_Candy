using System.Collections.Generic;

namespace Candyman.Models
{
  public class Flavor
  {
    public Catalog()
    {
      this.JoinEntities = new HashSet<TreatFlavor>();
    }

    public int FlavorId { get; set; }
    public string Description { get; set; }

    public virtual ICollection<TreatFlavor> JoinEntities { get; set; }
  }
}