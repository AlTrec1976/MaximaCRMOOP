namespace AcademyWith3thdLayer.Views;

public class CourseWindow
{
    public static void ShowWindow()
    {
        Console.WriteLine("Создание курса");
        Console.Write($"\n1) Название курса " +
                      $"\n2) Выбрать преподавателя " +
                      "\n3) Выбрать студента " +
                      "\nДля возврата, нажмите любую другую клавишу " +
                      "\n\nВаше решение: "
        );
    }
}