using AcademyWith3thdLayer.Views;
using ConsoleApp7.BLL.Logic;
using ConsoleApp7.BLL.Logic.Contracts.Students;
using ConsoleApp7.Common.Entities.StudentsModels;
using ConsoleApp7.Common.Utils.Helpers;

namespace AcademyWith3thdLayer;

public class Program
{
    private static readonly IStudentLogic _studentLogic;

    static Program()
    {
        _studentLogic = new StudentLogic();
    }
    
    static void Main(string[] args)
    {
        Start();
    }

    private static void Start()
    {
        MainWindow.ShowWindow();
        var chois = ReadChois();
        Switcher(chois);
    }

    private static void Switcher(int chois)
    {
        switch (chois)
        {
            case 1:
                Console.WriteLine("Введите название предмета:");
                var student = StudentHelper.EntryDataStudentHelper();
                _studentLogic.CreateStudent(student);
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            default:
                break;
        }
    }

    private static int ReadChois()
    {
        int chois = -1;

        while (chois == -1)
        {
            try
            {
                chois = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Введите корректное значение");
                chois = -1;
            }
        }
        return chois;
    }
}