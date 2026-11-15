namespace BSIT_32E3_Elective_2_Assignment_1.Models;

public class QuizQuestion
{
    public int Number { get; set; }
    public string Text { get; set; } = string.Empty;

    public Dictionary<string, string> Options { get; set; } = new();

    public string CorrectKey { get; set; } = string.Empty;
    public string Explanation { get; set; } = string.Empty;
}
