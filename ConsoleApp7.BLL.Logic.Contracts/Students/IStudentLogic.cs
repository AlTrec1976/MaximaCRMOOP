using ConsoleApp7.Common.Entities.StudentsModels;

namespace ConsoleApp7.BLL.Logic.Contracts.Students;

public interface IStudentLogic
{
    void CreateStudent(Student student);
}