using ConsoleApp7.Common.Entities.SubjectsModels;
using ConsoleApp7.Common.Entities.TeachersModels;
using ConsoleApp7.DAL.Repository;

namespace ConsoleApp7.Common.Utils.Helpers;

public static class TeacherHelper
{
    public static Teacher EntryDataTeacherHelper()
    {
        Console.WriteLine("Введите преподавателя:");
        var name = Console.ReadLine();

        List<string> subject = new List<string>();
        int index = default;
        while (true)
        {
            Console.WriteLine("Выбрите предмет:");
            
            for (int i = 0; i < Storage.Subjects.Count; i++)
            {
                Console.WriteLine(i+1 + ") " + Storage.Subjects[i].Name);
            }
            
            Console.WriteLine("Для возврата нажмите любую другую кнопку");

            try
            {
                index = int.Parse(Console.ReadLine())-1;
                subject.Add(Storage.Subjects[index].Name);
            }
            catch (Exception e)
            {
                break;
            }
        }

        return new Teacher { Name = name, Subject = subject};
    }
}