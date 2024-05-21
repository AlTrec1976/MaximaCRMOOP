using ConsoleApp7.Common.Entities.CoursesModels;
using ConsoleApp7.Common.Entities.SubjectsModels;
using ConsoleApp7.Common.Entities.TeachersModels;

namespace ConsoleApp7.Common.Utils.Helpers;

public static class CourseHelper
{
    public static Course EntryDataCourseHelper(string subject, string teacher)
    {
        /*
        var subject = Console.ReadLine();
        var teacher = Console.ReadLine();
        */
        
        return new Course { Subject = subject, Teacher = teacher };
    }
}