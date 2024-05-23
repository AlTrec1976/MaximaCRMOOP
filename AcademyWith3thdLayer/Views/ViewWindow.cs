using ConsoleApp7.DAL.Repository;

namespace AcademyWith3thdLayer.Views;

public class ViewWindow
{
    public ViewWindow(int index)
    {
        Console.WriteLine("Курс: " + Storage.Courses[index].Subject);
        Console.WriteLine("Преподаватель: " + Storage.Courses[index].Teacher);
        Console.WriteLine("Студенты:"); 
        
        foreach (var item in Storage.Courses[index].Students)
        {
            index++;
            Console.WriteLine("\t" + index + ". " + item.Name);
        }

        Console.WriteLine("Для возврата, нажмите любую клавишу");
        Console.ReadLine();
    }
}