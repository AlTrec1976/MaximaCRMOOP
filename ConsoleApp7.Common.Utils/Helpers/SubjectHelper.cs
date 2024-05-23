using ConsoleApp7.Common.Entities.SubjectsModels;

namespace ConsoleApp7.Common.Utils.Helpers;

public static class SubjectHelper
{
    public static Subject EntryDataSubjectHelper()
    {
        Console.WriteLine("Введите название предмета:");
        var name = Console.ReadLine();
        
        return new Subject { Name = name };
    }
}