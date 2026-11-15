namespace BSIT_32E3_Elective_2_Assignment_1.Models;

public class QuizViewModel
{
    public string Title { get; set; } = string.Empty;
    public string Subtitle { get; set; } = string.Empty;
    public IReadOnlyList<QuizQuestion> Questions { get; set; } = new List<QuizQuestion>();
}
