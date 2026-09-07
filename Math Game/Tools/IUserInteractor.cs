using Math_Game.Enums;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("MathGameTests")]

namespace Math_Game.Tools
{
    internal interface IUserInteractor
    {
        public void DisplayMenu();
        public string PromptForOption();
        public void DisplayMessage(string message);
        public string PromptForAnswer();
        public void DisplayCorrect();
        public void DisplayIncorrect(string result);
        public bool PromptForGameEnd();
        public void DisplayResults(List<int> results);
        public void DisplayDifficulties();
        public string PromptForDifficulty();
        public void Clear();
        public void Quit();
    }
    internal class ConsoleUserInteractor : IUserInteractor
    {
        Validator _validator;

        public ConsoleUserInteractor(Validator validator)
        {
            _validator = validator;
        }

        public void DisplayMenu()
        {
            Console.WriteLine();
            foreach(var option in Enum.GetNames<MenuOptions>())
            {
                Console.WriteLine(option);
            }
            Console.WriteLine();
        }
        public void DisplayDifficulties()
        {
            Console.WriteLine();
            foreach (var option in Enum.GetNames<Difficulty>())
            {
                Console.WriteLine(option);
            }
            Console.WriteLine();
        }
        public string PromptForOption()
        {
            string? userInput = null;
            bool isInputValid;
            do
            {
                Console.WriteLine("Choose from the list what type of game you want to play by selecting the option name.");
                Console.WriteLine("");
                userInput = Console.ReadLine();
                isInputValid = _validator.ValidateMenuOption(userInput);
            } while (!isInputValid);
            return userInput;
        }

        public string PromptForDifficulty()
        {
            string? userInput = null;
            bool isInputValid;
            do
            {
                Console.WriteLine("Choose the difficulty you prefer by selecting the option name.");
                Console.WriteLine("");
                userInput = Console.ReadLine();
                isInputValid = _validator.ValidateDifficulty(userInput);
            } while (!isInputValid);
            return userInput;
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        
        public string PromptForAnswer()
        {
            string _userInput;
            Console.WriteLine("-----------------------------");
            Console.Write($"|        Your answer: {_userInput = Console.ReadLine()}       |");
            return _userInput;
        }

        public void DisplayCorrect()
        {
           Console.ForegroundColor = ConsoleColor.Green;
           Console.WriteLine();
           Console.WriteLine("------------");
           Console.WriteLine("| Correct! |");
           Console.WriteLine("------------");
            Console.WriteLine(@"
             .-""""""""""""-.
          .-'                '-.
        .'                      '.
       /                          \
      /                            \
     :       ██          ██        :
     |      ████        ████       |
     |      ████        ████       |
     :                              :
     |                              |
     |     (                  )     |
     |      \                /      |
     |       \              /       |
     |        '------------'        |
     :                              :
      \                            /
       '.                        .'
         '-.                  .-'
            '-.____________.-'
");
            Console.ResetColor();
            Console.WriteLine("Press any key to continue to the next question.");
            Console.ReadKey();
            Console.Clear();
        }

        public void DisplayIncorrect(string result)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"| Incorrect! The result was {result} |");
            Console.WriteLine("-------------------------------");
            Console.WriteLine(@"
             .-""""""""""""-.
          .-'                '-.
        .'                      '.
       /                          \
      /                            \
     :       ██          ██        :
     |      ████        ████       |
     |      ████        ████       |
     :                              :
     |                              |
     |        .------------.        |
     |       /              \       |
     |      /                \      |
     |     (                  )     |
     :                              :
      \                            /
       '.                        .'
         '-.                  .-'
            '-.____________.-'
");
            Console.ResetColor();
            Console.WriteLine("Press any key to continue to the next question.");
            Console.ReadKey();
            Console.Clear();
        }
        public bool PromptForGameEnd()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("| Do you want to play again? Y/N |");
            Console.WriteLine("----------------------------------");
            return Console.ReadLine().ToUpper() == "Y";
        }

        public void DisplayResults(List<int> results) => results
            .Select((result, i) => (result, i))
            .ToList()
            .ForEach(result => Console.WriteLine($"| - Game n°{result.i + 1}: {result.result} points. - |"));

        public void Clear()
        {
            Console.Clear();
        }
        public void Quit()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("| Thanks for playing! Press any key to exit. |");
            Console.WriteLine("---------------------------------------------");
            Console.ReadKey();
        }
    }
}