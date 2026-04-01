namespace ExamApi.DTOs;

public class SubmitRequest
{
    public string? Name { get; set; }
    public List<AnswerDto>? Answers { get; set; }
}