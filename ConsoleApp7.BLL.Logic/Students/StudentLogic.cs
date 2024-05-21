using ConsoleApp7.BLL.Logic.Contracts.Students;
using ConsoleApp7.Common.Entities.StudentsModels;
using ConsoleApp7.DAL.Repository;

namespace ConsoleApp7.BLL.Logic;

public class StudentLogic : IStudentLogic
{
    public void CreateStudent(Student student)
    {
        Storage.Students.Add(student);
    }
}