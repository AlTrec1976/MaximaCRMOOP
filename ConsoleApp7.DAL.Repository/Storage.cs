using ConsoleApp7.Common.Entities.StudentsModels;

namespace ConsoleApp7.DAL.Repository;

public static class Storage
{
    public static List<Student> Students { get; set; } = new List<Student>();
}