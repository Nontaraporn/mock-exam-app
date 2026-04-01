using Microsoft.AspNetCore.Mvc;
using ExamApi.Models;
using ExamApi.DTOs;
using MockTest; // AppDbContext

namespace ExamApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExamController : ControllerBase
{
    private readonly ExamService _service;
    private readonly AppDbContext _db;

    public ExamController(AppDbContext db, ExamService service)
    {
        _db = db;
        _service = service;
    }
    // public ExamController()
    // {
    //     _service = new ExamService();
    // }

    [HttpGet("quiz")]
    public IActionResult GetQuiz()
    {
        return Ok(_service.GetQuiz());
    }
    
    [HttpPost("submit")]
    public IActionResult Submit([FromBody] SubmitRequest dto)
    {
        var quizs = _service.GetQuiz();
        int score = 0;

        Console.WriteLine("#########----[DEBUG]----#########");
        
        Console.WriteLine($"=> User : {dto.Name}");
        Console.WriteLine(quizs);
        Console.WriteLine(dto.Answers);
        foreach (var ans in dto.Answers)
        {
            var q = quizs.FirstOrDefault(x => x.id == ans.QuizID);
            if (q == null) continue;

            var correct = q.Choices.FirstOrDefault(c => c.IsCorrect);

            if (correct != null && correct.id == ans.ChoiceID)
            {
                score++;
            }
        }

        Console.WriteLine($"=> User : {dto.Name}");
        Console.WriteLine(score);
        Console.WriteLine(dto.Answers.Count);

        var result = new Result
        {
            Name = dto.Name,
            Score = score,
            Total = quizs.Count,
            CreatedAt = DateTime.Now
        };

        _db.Results.Add(result);
        _db.SaveChanges();

        return Ok(result);
    }

    [HttpGet("results")]
    public IActionResult GetResults()
    {
        return Ok(_db.Results
            .OrderByDescending(x => x.CreatedAt)
            .ToList());
    }

    // [HttpGet("results")]
    // public IActionResult GetResults()
    // {
    //     return Ok(_db.Results.OrderByDescending(x => x.CreatedAt).ToList());
    // }

    [HttpGet("test")]
    public IActionResult Test()
    {
        return Ok("API is working!");
    }
}