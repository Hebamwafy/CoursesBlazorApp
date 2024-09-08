using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CoursesBlazorApp.Models;
public class Student
{

    public int Id { get; set; }

    [Required(ErrorMessage = "Student Name Required")]
    [MinLength(2, ErrorMessage = "Please Enter Valid Name")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Student address Required")]
    [MinLength(2, ErrorMessage = "Please Enter Valid Address")]
    public string Address { get; set; } = string.Empty;
    public int Age { get; set; }
    public HashSet<Enrollment> Enrollments { get; set; } = new HashSet<Enrollment>();
}