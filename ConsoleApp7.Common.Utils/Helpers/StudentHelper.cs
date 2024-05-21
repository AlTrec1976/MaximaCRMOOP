using ConsoleApp7.Common.Entities.StudentsModels;

namespace ConsoleApp7.Common.Utils.Helpers;

public static class StudentHelper
{
    public static Student EntryDataStudentHelper()
    {
        var name = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        
        return new Student { Name = name, Age = age };
    }
}