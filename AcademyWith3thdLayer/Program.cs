using AcademyWith3thdLayer.Views;
using ConsoleApp7.BLL.Logic;
using ConsoleApp7.BLL.Logic.Contracts.Students;
using ConsoleApp7.BLL.Logic.Contracts.Subjects;
using ConsoleApp7.BLL.Logic.Contracts.Teachers;
using ConsoleApp7.BLL.Logic.Courses;
using ConsoleApp7.BLL.Logic.Subjects;
using ConsoleApp7.BLL.Logic.Teachers;
using ConsoleApp7.Common.Entities.SubjectsModels;
using ConsoleApp7.Common.Entities.TeachersModels;
using ConsoleApp7.Common.Entities.StudentsModels;
using ConsoleApp7.Common.Utils.Helpers;
using ConsoleApp7.DAL.Repository;

namespace AcademyWith3thdLayer;

public class Program
{
    private static string subject = string.Empty;
    private static string teacher = string.Empty;

    private static readonly ISubjectLogic _subjectLogic;
    private static readonly ITeacherLogic _teacherLogic;
    private static readonly IStudentLogic _studentLogic;
    private static readonly CourseLogic _courseLogic;

    static Program()
    {
        _subjectLogic = new SubjectLogic();
        _teacherLogic = new TeacherLogic();
        _studentLogic = new StudentLogic();
        _courseLogic = new CourseLogic();
    }
    
    static void Main(string[] args)
    {
        Start();
    }

    private static void Start()
    {
        int chois = default;
        while (chois>-1)
        {
            MainWindow.ShowWindow();
            
            chois = ReadChois();
            Switcher(chois);
        }
    }

    private static void IntroduceCourse()
    {
        int chois = default;
        while (chois>-1)
        {
            CourseWindow.ShowWindow();
            
            chois = ReadChois();
            SwitcherCourse(chois);
        }
        var course = CourseHelper.EntryDataCourseHelper(subject, teacher);
        _courseLogic.SaveCourse(course);
    }
    
    private static void SwitcherCourse(int chois)
    {
        int index = default;
        switch (chois)
        {
            case 1:
                Console.WriteLine("Выбрите предмет:");
                for (int i = 0; i < Storage.Subjects.Count; i++)
                {
                    Console.WriteLine(i + ") " + Storage.Subjects[i].Name);
                }
                index = int.Parse(Console.ReadLine());
                subject = Storage.Subjects[index].Name;
                break;
            case 2:
                Console.WriteLine("Выбрите преподавателя:");
                for (int i = 0; i < Storage.Teachers.Count; i++)
                {
                    Console.WriteLine(i + ") " + Storage.Teachers[i].Name);
                }
                index = int.Parse(Console.ReadLine());
                teacher = Storage.Teachers[index].Name;
                break;
            case 3:
                Console.WriteLine("Выбрите студента:");
                for (int i = 0; i < Storage.Students.Count; i++)
                {
                    Console.WriteLine(i + ") " + Storage.Students[i].Name);
                }
                index = int.Parse(Console.ReadLine());
                break;
            default:
                break;
        }
    }

    private static void Switcher(int chois)
    {
        switch (chois)
        {
            case 1:
                Console.WriteLine("Введите название предмета:");
                var subject = SubjectHelper.EntryDataSubjectHelper();
                _subjectLogic.SaveSubject(subject);
                break;
            case 2:
                Console.WriteLine("Введите преподавателя:");
                var teacher = TeacherHelper.EntryDataTeacherHelper();
                _teacherLogic.SaveTeacher(teacher);
                break;
            case 3:
                Console.WriteLine("Введите студента, затем его возраст:");
                var student = StudentHelper.EntryDataStudentHelper();
                _studentLogic.CreateStudent(student);
                break;
            case 4:
                IntroduceCourse();
                break;
            case 5:
                Console.WriteLine("Выберите курс:");
                for (int i = 0; i < Storage.Courses.Count; i++)
                {
                    Console.WriteLine(i + ") " + Storage.Courses[i].Subject);
                }
                _courseLogic.ViewCourse(int.Parse(Console.ReadLine()));
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
                break;
            }
        }
        
        return chois;
    }
}