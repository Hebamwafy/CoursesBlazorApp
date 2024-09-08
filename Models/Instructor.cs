using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoursesBlazorApp.Models;
public class Instructor
{

    public int Id { get; set; }

    [Required(ErrorMessage = "Instructor Name Required")]
    [MinLength(2, ErrorMessage = "Please Enter Valid Name")]
    public string Name { get; set; } = string.Empty;

    [ForeignKey("Course")]
    public int CourseId { get; set; }
}