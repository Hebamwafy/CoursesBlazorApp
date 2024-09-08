using CoursesBlazorApp.Models;
using Microsoft.EntityFrameworkCore;
namespace CoursesBlazorApp.CoursesDBContext{

    public class CoursesDbContext: DbContext
    {


    public  DbSet<Student>? Students { get; set; }
    public  DbSet<Course>? Courses { get; set; }
    public  DbSet<Instructor>? Instructors { get; set; }
    public  DbSet<Enrollment>? Enrollments {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Enrollment>()
                .HasKey(e => new { e.StudentId, e.CourseId });

            modelBuilder.Entity<Enrollment>()
                .HasOne(s => s.Student)
                .WithMany(e => e.Enrollments)
                .HasForeignKey(s => s.StudentId);

            modelBuilder.Entity<Enrollment>()
                .HasOne(c => c.Course)
                .WithMany(e => e.Enrollments)
                .HasForeignKey(c => c.CourseId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=CoursesDB.db");

        }
    }

}