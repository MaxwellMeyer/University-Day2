namespace University.Models
{
  public class DeptStudent
  {
    public int DeptStudentId { get; set; }
    public int StudentId { get; set; }
    public int DeptId { get; set; }

    public virtual Student Student { get; set; }
    public virtual Dept Dept { get; set; }
  }
}