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
            Console.Write("Enter a number: ");

            try
            {
                int number = int.Parse(Console.ReadLine());

                // Perform FizzBuzz logic
                string result = FizzBuzzKalkyl(number);

                // Log the result
                Console.WriteLine(result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}