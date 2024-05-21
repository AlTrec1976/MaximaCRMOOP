using ConsoleApp7.Common.Entities.CoursesModels;
using ConsoleApp7.Common.Entities.StudentsModels;
using ConsoleApp7.Common.Entities.SubjectsModels;
using ConsoleApp7.Common.Entities.TeachersModels;

namespace ConsoleApp7.Common.Utils.Helpers;

public static class CourseHelper
{
    public static Course EntryDataCourseHelper(string subject, string teacher, List<Student> students)
    {
        /*
        var subject = Console.ReadLine();
        var teacher = Console.ReadLine();
        */
        
        return new Course( subject, teacher, students  );
    }
}