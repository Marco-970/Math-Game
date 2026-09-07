using Math_Game.Enums;

namespace Math_Game.Application
{
    internal class QuestionGenerator
    {
        public Question[] Generate(MenuOptions questionType)
        {
            return questionType switch
            {
                MenuOptions.Sum => new Question[]
                {
                    new Question("What's the result of 5 + 5?", "10"),
                    new Question("What's the result of 15 + 3?", "18"),
                    new Question("What's the result of 6 + 2?", "8"),
                    new Question("What's the result of 54 + 62?", "116"),
                    new Question("What's the result of 1 + 0?", "1")
                },
                MenuOptions.Subtraction => new Question[]
                {
                    new Question("What's the result of 5 - 5?", "0"),
                    new Question("What's the result of 15 - 3?", "12"),
                    new Question("What's the result of 6 - 2?", "4"),
                    new Question("What's the result of 62 - 54?", "8"),
                    new Question("What's the result of 1 - 0?", "1")
                },
                MenuOptions.Multiplication => new Question[]
                {
                    new Question("What's the result of 5 x 5?", "25"),
                    new Question("What's the result of 15 x 3?", "45"),
                    new Question("What's the result of 6 x 2?", "12"),
                    new Question("What's the result of 54 x 62?", "3348"),
                    new Question("What's the result of 1 x 0?", "0")
                },
                MenuOptions.Division => new Question[]
                {
                    new Question("What's the result of 5 / 5?", "1"),
                    new Question("What's the result of 15 / 3?", "5"),
                    new Question("What's the result of 6 / 2?", "3"),
                    new Question("What's the result of 36 / 4?", "9"),
                    new Question("What's the result of 2 / 1?", "2")
                }
            };
        }
    }
}