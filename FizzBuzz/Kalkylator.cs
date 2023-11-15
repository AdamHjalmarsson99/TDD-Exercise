namespace FizzBuzz
{
    public class Kalkylator
    {

        public static string FizzBuzzKalkyl(int number)
        {
            string result = "";

            if (number % 3 == 0)
                result += "Fizz";

            if (number % 5 == 0)
                result += "Buzz";

            if (number % 7 == 0)
                result += "Whizz";

            if (number % 11 == 0)
                result += "Bang";

            return string.IsNullOrEmpty(result) ? number.ToString() : result;
        }

        public static void LogMessage(int number)
        {
            Console.WriteLine(FizzBuzzKalkyl(number));
        }

        public static void LogMessageFromUserInput()
        {
            // Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int number))
            {
                string result = FizzBuzzKalkyl(number);

                Console.WriteLine(result);
            }
            else
            {
                throw new ArgumentException($"{number} is not a valid number. Please enter a valid number.");
            }
        }

    }
}