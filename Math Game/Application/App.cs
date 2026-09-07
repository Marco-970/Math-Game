using Math_Game.Enums;
using Math_Game.Tools;

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
            _userInteractor.Clear();
            _userInteractor.DisplayMessage("Welcome! Here are the types of the games. Each option will have 5 questions about that type of operation.");
            _userInteractor.DisplayMenu();
            MenuOptions _userChoice;
            do
            {
                _userChoice = Enum.Parse<MenuOptions>(_userInteractor.PromptForOption());
                if (_userChoice == MenuOptions.Records)
                {
                    _userInteractor.DisplayResults(_gameResults.Results);
                    _userInteractor.DisplayMenu();
                }
            } while (_userChoice == MenuOptions.Records);
            _userInteractor.Clear();
            _quiz.StartGame(_userChoice);
            _gameResults.Results.Add(_quiz.Points);
            _isGameFinished = !_userInteractor.PromptForGameEnd();
        }
    }
}