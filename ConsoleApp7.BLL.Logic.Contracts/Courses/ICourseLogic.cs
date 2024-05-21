using ConsoleApp7.Common.Entities.CoursesModels;

namespace ConsoleApp7.BLL.Logic.Contracts.Courses;

public interface ICourseLogic
{
    void SaveCourse(Course course);
    void ViewCourse(int index);
}