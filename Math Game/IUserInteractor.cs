namespace Math_Game
{
    internal interface IUserInteractor
    {
        public void DisplayMenu();
        public MenuOptions PromptForOptions();
    }
    internal class ConsoleUserInteractor : IUserInteractor
    {
        public void DisplayMenu()
        {

        }
        public MenuOptions PromptForOptions()
        {
            Console.WriteLine("Choose from the list what type of game you want to play");
        }
    }
}