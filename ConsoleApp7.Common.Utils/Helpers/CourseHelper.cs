using ConsoleApp7.Common.Entities.CoursesModels;
using ConsoleApp7.Common.Entities.StudentsModels;
using ConsoleApp7.Common.Entities.SubjectsModels;
using ConsoleApp7.Common.Entities.TeachersModels;
using ConsoleApp7.DAL.Repository;

namespace ConsoleApp7.Common.Utils.Helpers;

public static class CourseHelper
{
    public static Course EntryDataCourseHelper(string subject, string teacher, List<Student> students)
    {
        return new Course {Subject = subject, Teacher = teacher, Students = students};
    }
}