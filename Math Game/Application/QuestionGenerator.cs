using Math_Game.Enums;
using Math_Game.Tools;
using System;
using System.Runtime.CompilerServices;


[assembly: InternalsVisibleTo("MathGameTests")]

namespace Math_Game.Application
{
    internal class QuestionGenerator
    {
        IRandom _random;
        public QuestionGenerator(IRandom random)
        {
            _random = random;
        }

        public Question Generate(Difficulty difficulty, MenuOptions questionType)
        {
            return (difficulty, questionType) switch
            {
                (Difficulty.Easy, MenuOptions.Sum) => QuestionsRepository.EasyQuestionsSum
                    .ElementAt(_random
                    .Next(QuestionsRepository.EasyQuestionsSum.Count())),
                (Difficulty.Easy, MenuOptions.Subtraction) => QuestionsRepository.EasyQuestionsSubtraction
                    .ElementAt(_random
                    .Next(QuestionsRepository.EasyQuestionsSubtraction.Count())),
                (Difficulty.Easy, MenuOptions.Multiplication) => QuestionsRepository.EasyQuestionsMultiplication
                    .ElementAt(_random
                    .Next(QuestionsRepository.EasyQuestionsMultiplication.Count())),
                (Difficulty.Easy, MenuOptions.Division) => QuestionsRepository.EasyQuestionsDivision
                    .ElementAt(_random
                    .Next(QuestionsRepository.EasyQuestionsDivision.Count())),
                (Difficulty.Medium, MenuOptions.Sum) => QuestionsRepository.MediumQuestionsSum
                    .ElementAt(_random
                    .Next(QuestionsRepository.MediumQuestionsSum.Count())),
                (Difficulty.Medium, MenuOptions.Subtraction) => QuestionsRepository.MediumQuestionsSubtraction
                    .ElementAt(_random
                    .Next(QuestionsRepository.MediumQuestionsSubtraction.Count())),
                (Difficulty.Medium, MenuOptions.Multiplication) => QuestionsRepository.MediumQuestionsMultiplication
                    .ElementAt(_random
                    .Next(QuestionsRepository.MediumQuestionsMultiplication.Count())),
                (Difficulty.Medium, MenuOptions.Division) => QuestionsRepository.MediumQuestionsDivision
                    .ElementAt(_random
                    .Next(QuestionsRepository.MediumQuestionsDivision.Count())),
                (Difficulty.Hard, MenuOptions.Sum) => QuestionsRepository.MediumQuestionsSum
                    .ElementAt(_random
                    .Next(QuestionsRepository.MediumQuestionsSum.Count())),
                (Difficulty.Hard, MenuOptions.Subtraction) => QuestionsRepository.MediumQuestionsSubtraction
                    .ElementAt(_random
                    .Next(QuestionsRepository.MediumQuestionsSubtraction.Count())),
                (Difficulty.Hard, MenuOptions.Multiplication) => QuestionsRepository.MediumQuestionsMultiplication
                    .ElementAt(_random
                    .Next(QuestionsRepository.MediumQuestionsMultiplication.Count())),
                (Difficulty.Hard, MenuOptions.Division) => QuestionsRepository.MediumQuestionsDivision
                    .ElementAt(_random
                    .Next(QuestionsRepository.MediumQuestionsDivision.Count())),
            };
        }
    }
}