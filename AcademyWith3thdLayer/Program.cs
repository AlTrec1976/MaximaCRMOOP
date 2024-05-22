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
    static List<Student> _students = new List<Student>();

    private static string _subject = string.Empty;
    private static string _teacher = string.Empty;

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

        List<Student> students = new List<Student>(_students);
        var course = CourseHelper.EntryDataCourseHelper(_subject, _teacher, students);
        _courseLogic.SaveCourse(course);
        _students.Clear();
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
                    Console.WriteLine(i+1 + ") " + Storage.Subjects[i].Name);
                }
                index = int.Parse(Console.ReadLine())-1;
                _subject = Storage.Subjects[index].Name;
                break;
            case 2:
                Console.WriteLine("Выбрите преподавателя:");
                for (int i = 0; i < Storage.Teachers.Count; i++)
                {
                    if (Storage.Teachers[i].Subject.IndexOf(_subject) >= 0)
                    {
                        Console.WriteLine(i+1 + ") " + Storage.Teachers[i].Name);
                    }
                }

                Console.WriteLine("Для возврата нажмите любую другую кнопку");
                index = int.Parse(Console.ReadLine())-1;
                _teacher = Storage.Teachers[index].Name;
                break;
            case 3:
                Console.WriteLine("Выбрите студента:");
                for (int i = 0; i < Storage.Students.Count; i++)
                {
                    Console.WriteLine(i+1 + ") " + Storage.Students[i].Name);
                }
                Console.WriteLine("Для возврата нажмите любую другую кнопку");
                index = int.Parse(Console.ReadLine())-1;
                _students.Add(Storage.Students[index]);
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
                var subject = SubjectHelper.EntryDataSubjectHelper();
                _subjectLogic.SaveSubject(subject);
                break;
            case 2:
                var teacher = TeacherHelper.EntryDataTeacherHelper();
                _teacherLogic.SaveTeacher(teacher);
                break;
            case 3:
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
                    Console.WriteLine(i+1 + ") " + Storage.Courses[i].Subject);
                }
                _courseLogic.ViewCourse(int.Parse(Console.ReadLine())-1);
                break;
            default:
                break;
        }
    }

    private static int ReadChois()
    {
        int chois = default;

        while (true)
        {
            try
            {
                chois = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception e)
            {
                chois = -1;
                break;
            }
        }
        
        return chois;
    }
}