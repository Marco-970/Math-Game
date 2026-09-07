using Math_Game.Enums;
using Math_Game.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game.Application
{
    internal class Quiz
    {
        IUserInteractor _userInteractor;
        QuestionGenerator _questionGenerator;
        public int Points { get; private set; }
        public Quiz(IUserInteractor userInteractor, QuestionGenerator questionGenerator)
        {
            _userInteractor = userInteractor;
            _questionGenerator = questionGenerator;
        }
        public void StartGame(MenuOptions quizMode)
        {
            var _questions = _questionGenerator.Generate(quizMode);
            int _points = 0;
            foreach(var _question in _questions)
            {
                _userInteractor.DisplayMessage(_question.Text);
                if(_userInteractor.PromptForAnswer() == _question.Result)
                {
                    _points++;
                    _userInteractor.DisplayCorrect();
                }
                else { _userInteractor.DisplayIncorrect(_question.Result); }
            }
            Points = _points;
            _userInteractor.DisplayMessage("");
            _userInteractor.DisplayMessage($"Final result: {Points} points.");
        }
    }
}
