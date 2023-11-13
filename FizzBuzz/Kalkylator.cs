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

        public static int FizzBuzzCalculatorOutput(int number)
        {
            return number;
        }

        public void LogMessage(int number)
        {
            string message = FizzBuzzKalkyl(number);
            Console.WriteLine($"{message}");
        }
    }
}