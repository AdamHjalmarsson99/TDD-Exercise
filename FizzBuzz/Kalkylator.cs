namespace FizzBuzz
{
    public class Kalkylator
    {
        
        public static string FizzBuzzKalkyl(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";

            else if (number % 5 == 0)
                return "Buzz";

            else if (number % 3 == 0)
                return "Fizz";

            else
                return number.ToString();
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