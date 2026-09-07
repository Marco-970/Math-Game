namespace Math_Game
{
    internal class App
    {
        IUserInteractor _userInteractor;

        public App(IUserInteractor userInteractor)
        {
            _userInteractor = userInteractor;
        }

        public void Run()
        {
            _userInteractor.DisplayMenu();
            _userInteractor.PromptForOption(); //returns enum menu options

        }
    }
}