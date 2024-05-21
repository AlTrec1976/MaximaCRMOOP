using ConsoleApp7.Common.Entities.StudentsModels;

namespace ConsoleApp7.Common.Entities.CoursesModels;

public class Course
{
    /*
    public List<Student> Students = new List<Student>();
    */

    #region Prorertys

    public string Subject { get; set; }
    public string Teacher { get; set; }

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