namespace ExamApi.Models;

public class Result
{
    public int id { get; set; }
    public string? Name { get; set; } = "";
    public int Score { get; set; }
    public int Total { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}