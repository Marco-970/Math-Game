using Math_Game.Enums;

namespace Math_Game.Tools
{
    internal class Validator
    {
        public bool ValidateEnum(string input) => Enum.GetNames<MenuOptions>().Contains(input);
    }
}