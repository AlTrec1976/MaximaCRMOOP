using ConsoleApp7.Common.Entities.TeachersModels;

namespace ConsoleApp7.BLL.Logic.Contracts.Teachers;

public interface ITeacherLogic
{
    void SaveTeacher(Teacher teacher);
}