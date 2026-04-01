namespace ExamApi.Models;

public class Quiz
{
    public int id { get; set; }
    public string? QuizText { get; set; }
    public List<Choice>? Choices { get; set; }
}