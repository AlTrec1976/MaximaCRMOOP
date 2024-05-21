using ConsoleApp7.BLL.Logic.Contracts.Subjects;
using ConsoleApp7.Common.Entities.SubjectsModels;
using ConsoleApp7.DAL.Repository;

namespace ConsoleApp7.BLL.Logic.Subjects;

public class SubjectLogic : ISubjectLogic
{
    public void SaveSubject(Subject subject)
    {
        Storage.Subjects.Add(subject);
    }
}