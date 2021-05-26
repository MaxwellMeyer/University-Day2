using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace University.Models
{
  public class Student
  {
    public Student()
    {
      this.JoinEntities = new HashSet<CourseStudent>();
    }
    public int DeptId { get; set; }
    public int StudentId { get; set; }
    public string Name { get; set; }
    // public string EnrollmentDate { get; set; }

    [DisplayName("DateOfEnrollment")]
    [DataType(DataType.Date)]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime EnrollmentDate { get; set; }

    public virtual ICollection<CourseStudent> JoinEntities { get; }
  }
}
