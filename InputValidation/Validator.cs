namespace InputValidation
{
    public class Validator
    {
        public static bool IsValidChoice(string choice)
        {
            return choice == "1" ||
                   choice == "2" ||
                   choice == "3" ||
                   choice == "4" ||
                   choice == "5";
        }

        public static bool IsValidNumber(string input, out double number)
        {
            return double.TryParse(input, out number);
        }
    }
}