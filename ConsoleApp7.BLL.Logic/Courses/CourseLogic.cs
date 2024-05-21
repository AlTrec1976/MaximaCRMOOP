using ConsoleApp7.BLL.Logic.Contracts.Courses;
using ConsoleApp7.Common.Entities.CoursesModels;
using ConsoleApp7.DAL.Repository;

namespace ConsoleApp7.BLL.Logic.Courses;

public class CourseLogic : ICourseLogic
{
    public void SaveCourse(Course course)
    {
        Storage.Courses.Add(course);
    }

    public void ViewCourse(int index)
    {
        Console.WriteLine("Курс: " + Storage.Courses[index].Subject);
        Console.WriteLine("Преподаватель: " + Storage.Courses[index].Teacher);
        Console.WriteLine("Студенты:"); 
        
        foreach (var item in Storage.Courses[index].Students)
        {
            index++;
            Console.WriteLine("\t" + index + ". " + item.Name);
        }

        /*
        if (int.TryParse(Console.ReadLine(), out int choiceIndex) && choiceIndex < _courses.Count)
        {
        }
        else
        {
            Console.WriteLine("Нет такого курса.");
        }
        */
        
        Console.WriteLine("Для возврата, нажмите любую клавишу");
        Console.ReadLine();

    }
}