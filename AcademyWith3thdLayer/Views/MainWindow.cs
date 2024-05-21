namespace AcademyWith3thdLayer.Views;

public class MainWindow
{
    public static void ShowWindow()
    {
        Console.WriteLine("Добро пожаловать в Академию!");
        Console.Write(
            "\n1) Создать предмет " +
            "\n2) Создать преподавателя " +
            "\n3) Создать студента " +
            "\n4) Создать курс " +
            "\n5) Просмотреть курс " +
            "\nДля выхода, нажмите любую другую клавишу " +
            "\n\nВаше решение: "
            );
    }
}