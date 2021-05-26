using System.Collections.Generic;

namespace University.Models
{
  public class Dept
  {
    public Dept()
    {
      this.JoinEntities = new HashSet<DeptStudent>();
    }
    public int DeptId { get; set; }

    public string Name { get; set; }

    public virtual ICollection<DeptStudent> JoinEntities { get; }

  }
}