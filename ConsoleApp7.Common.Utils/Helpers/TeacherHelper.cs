using ConsoleApp7.Common.Entities.TeachersModels;

namespace ConsoleApp7.Common.Utils.Helpers;

public static class TeacherHelper
{
    public static Teacher EntryDataTeacherHelper()
    {
        var name = Console.ReadLine();

        return new Teacher { Name = name};
    }
}