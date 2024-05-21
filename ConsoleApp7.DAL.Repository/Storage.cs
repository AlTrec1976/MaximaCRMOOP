using ConsoleApp7.Common.Entities.CoursesModels;
using ConsoleApp7.Common.Entities.StudentsModels;
using ConsoleApp7.Common.Entities.SubjectsModels;
using ConsoleApp7.Common.Entities.TeachersModels;

namespace ConsoleApp7.DAL.Repository;

public static class Storage
{
    public static List<Student> Students { get; set; } = new List<Student>();
    
    public static List<Teacher> Teachers { get; set; } = new List<Teacher>();

    public static List<Subject> Subjects { get; set; } = new List<Subject>();

    public static List<Course> Courses { get; set; } = new List<Course>();

    
}