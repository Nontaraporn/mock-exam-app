using ExamApi.Models;

public class ExamService
{
    public List<Quiz> GetQuiz()
    {
        return new List<Quiz>
        {
            new Quiz {
                id = 1,
                QuizText = "How many provinces are there in Thailand?",
                Choices = new List<Choice>
                {
                    new Choice { id = 1, ChoiceText = "75", IsCorrect = false },
                    new Choice { id = 2, ChoiceText = "76", IsCorrect = false },
                    new Choice { id = 3, ChoiceText = "77", IsCorrect = true },
                    new Choice { id = 4, ChoiceText = "78", IsCorrect = false }
                }
            },

            new Quiz {
                id = 2,
                QuizText = "Approximately how tall is the Eiffel Tower?",
                Choices = new List<Choice>
                {
                    new Choice { id = 1, ChoiceText = "250 meters", IsCorrect = false },
                    new Choice { id = 2, ChoiceText = "300 meters", IsCorrect = false },
                    new Choice { id = 3, ChoiceText = "330 meters", IsCorrect = true },
                    new Choice { id = 4, ChoiceText = "400 meters", IsCorrect = false }
                }
            },

            new Quiz {
                id = 3,
                QuizText = "What is the approximate value of Earth's gravity (m/s²)?",
                Choices = new List<Choice>
                {
                    new Choice { id = 1, ChoiceText = "7.8", IsCorrect = false },
                    new Choice { id = 2, ChoiceText = "9.8", IsCorrect = true },
                    new Choice { id = 3, ChoiceText = "12.0", IsCorrect = false },
                    new Choice { id = 4, ChoiceText = "15.5", IsCorrect = false }
                }
            },

            new Quiz {
                id = 4,
                QuizText = "How many days are there in a year (excluding leap years)?",
                Choices = new List<Choice>
                {
                    new Choice { id = 1, ChoiceText = "364", IsCorrect = false },
                    new Choice { id = 2, ChoiceText = "365", IsCorrect = true },
                    new Choice { id = 3, ChoiceText = "366", IsCorrect = false },
                    new Choice { id = 4, ChoiceText = "360", IsCorrect = false }
                }
            },

            new Quiz {
                id = 5,
                QuizText = "What was the approximate budget of Avengers: Endgame (in million USD)?",
                Choices = new List<Choice>
                {
                    new Choice { id = 1, ChoiceText = "200 million", IsCorrect = false },
                    new Choice { id = 2, ChoiceText = "356 million", IsCorrect = true },
                    new Choice { id = 3, ChoiceText = "500 million", IsCorrect = false },
                    new Choice { id = 4, ChoiceText = "150 million", IsCorrect = false }
                }
            },

            new Quiz {
                id = 6,
                QuizText = "What is the latest version of the Windows operating system?",
                Choices = new List<Choice>
                {
                    new Choice { id = 1, ChoiceText = "Windows 10", IsCorrect = false },
                    new Choice { id = 2, ChoiceText = "Windows 11", IsCorrect = true },
                    new Choice { id = 3, ChoiceText = "Windows 12", IsCorrect = false },
                    new Choice { id = 4, ChoiceText = "Windows XP", IsCorrect = false }
                }
            },

            new Quiz {
                id = 7,
                QuizText = "How many meters are in 1 kilometer?",
                Choices = new List<Choice>
                {
                    new Choice { id = 1, ChoiceText = "100", IsCorrect = false },
                    new Choice { id = 2, ChoiceText = "1000", IsCorrect = true },
                    new Choice { id = 3, ChoiceText = "10,000", IsCorrect = false },
                    new Choice { id = 4, ChoiceText = "500", IsCorrect = false }
                }
            },

            new Quiz {
                id = 8,
                QuizText = "What is Thailand’s time zone (UTC)?",
                Choices = new List<Choice>
                {
                    new Choice { id = 1, ChoiceText = "UTC+6", IsCorrect = false },
                    new Choice { id = 2, ChoiceText = "UTC+7", IsCorrect = true },
                    new Choice { id = 3, ChoiceText = "UTC+8", IsCorrect = false },
                    new Choice { id = 4, ChoiceText = "UTC+9", IsCorrect = false }
                }
            },

            new Quiz {
                id = 9,
                QuizText = "What is the approximate value of PI (π)?",
                Choices = new List<Choice>
                {
                    new Choice { id = 1, ChoiceText = "2.14", IsCorrect = false },
                    new Choice { id = 2, ChoiceText = "3.14", IsCorrect = true },
                    new Choice { id = 3, ChoiceText = "4.13", IsCorrect = false },
                    new Choice { id = 4, ChoiceText = "3.41", IsCorrect = false }
                }
            },

            new Quiz {
                id = 10,
                QuizText = "How many threads can 1 CPU core process (typically)?",
                Choices = new List<Choice>
                {
                    new Choice { id = 1, ChoiceText = "1", IsCorrect = true },
                    new Choice { id = 2, ChoiceText = "2", IsCorrect = false },
                    new Choice { id = 3, ChoiceText = "4", IsCorrect = false },
                    new Choice { id = 4, ChoiceText = "8", IsCorrect = false }
                }
            }
        };
    }
}