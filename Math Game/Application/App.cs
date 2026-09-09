using Math_Game.Enums;
using Math_Game.Tools;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("MathGameTests")]

namespace Math_Game.Application
{
    internal class App
    {
        IUserInteractor _userInteractor;
        Quiz _quiz;
        GameResults _gameResults;

        public bool IsGameFinished => _isGameFinished;
        bool _isGameFinished;

        public App(IUserInteractor userInteractor, Quiz quiz, GameResults gameResults)
        {
            _userInteractor = userInteractor;
            _quiz = quiz;
            _gameResults = gameResults;
        }

        public void Run()
        {
            Difficulty _userChoiceDifficulty;
            MenuOptions _userChoiceMenu;
            _userInteractor.Clear();
            _userInteractor.DisplayMessage("Welcome! Here are the various difficulties of the game.");
            _userInteractor.DisplayDifficulties();
            _userChoiceDifficulty = Enum.Parse<Difficulty>(_userInteractor.PromptForDifficulty());
            _userInteractor.DisplayMessage("Here are the types of the games. Each option will have 5 questions about that type of operation.");
            _userInteractor.DisplayMenu();
            do
            {
                _userChoiceMenu = Enum.Parse<MenuOptions>(_userInteractor.PromptForOption());
                if (_userChoiceMenu == MenuOptions.Records)
                {
                    _userInteractor.DisplayResults(_gameResults.Results);
                    _userInteractor.DisplayMenu();
                }
            } while (_userChoiceMenu == MenuOptions.Records);
            _userInteractor.Clear();
            _quiz.StartGame(_userChoiceDifficulty, _userChoiceMenu);
            _gameResults.Results.Add((_quiz.Points, _quiz.Time));
            _isGameFinished = !_userInteractor.PromptForGameEnd();
        }
    }
}