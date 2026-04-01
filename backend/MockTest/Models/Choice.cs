namespace ExamApi.Models;

public class Choice
{
    public int id { get; set; }
    public string? ChoiceText { get; set; }
    public bool IsCorrect { get; set; }
}