using System.ComponentModel.DataAnnotations;

namespace CoursesBlazorApp.Models;
public class Course{
    
        public int Id { get; set; }

        [Required(ErrorMessage = "Course Name Required")]
        [MinLength(2, ErrorMessage = "Please Enter Valid Name")]
        public string Name { get; set; } = string.Empty;
        public HashSet<Enrollment> Enrollments { get; set; } = new HashSet<Enrollment>();
    


}