using Math_Game.Application;
using Math_Game.Tools;

namespace Math_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUserInteractor _userInteractor = new ConsoleUserInteractor(new Validator());
            GameResults _gameResults = new GameResults();
            App app = new App(_userInteractor, new Quiz(_userInteractor, new QuestionGenerator()), _gameResults);

            app.Run();
            bool _isGameFinished = app.IsGameFinished;
            while (!_isGameFinished)
            {
                app = new App(_userInteractor, new Quiz(_userInteractor, new QuestionGenerator()), _gameResults);
                app.Run();
                _isGameFinished = app.IsGameFinished;
            }
            _userInteractor.Quit();
        }
    }
}
