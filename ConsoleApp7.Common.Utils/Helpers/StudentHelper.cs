using ConsoleApp7.Common.Entities.StudentsModels;

namespace ConsoleApp7.Common.Utils.Helpers;

public static class StudentHelper
{
    public static Student EntryDataStudentHelper()
    {
        Console.WriteLine("Введите студента:");
        var name = Console.ReadLine();
        Console.WriteLine("Введите его возраст:");
        var age = int.Parse(Console.ReadLine());
        
        return new Student { Name = name, Age = age };
    }
}