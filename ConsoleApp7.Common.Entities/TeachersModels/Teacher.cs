using ConsoleApp7.Common.Entities.SubjectsModels;

namespace ConsoleApp7.Common.Entities.TeachersModels;

public class Teacher
{
    #region Prorertys

    public string Name { get; set; }
    public List<string> Subject { get; set; } = new List<string>();

    #endregion
}