using ConsoleApp7.Common.Entities.StudentsModels;

namespace ConsoleApp7.Common.Entities.CoursesModels;

public class Course
{
    #region Prorertys

    public string Subject { get; set; }
    public string Teacher { get; set; }

    public List<Student> Students { get; set; } = new List<Student>();

    #endregion

    /*
    public Course(string subject, string teacher, List<Student> students)
    {
        Subject = subject;
        Teacher = teacher;
        Students = students;
    }
    */

}