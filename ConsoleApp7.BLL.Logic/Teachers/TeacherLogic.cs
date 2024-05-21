using ConsoleApp7.BLL.Logic.Contracts.Teachers;
using ConsoleApp7.Common.Entities.TeachersModels;
using ConsoleApp7.DAL.Repository;

namespace ConsoleApp7.BLL.Logic.Teachers;

public class TeacherLogic : ITeacherLogic
{
    public void SaveTeacher(Teacher teacher)
    {
        Storage.Teachers.Add(teacher);
    }
}