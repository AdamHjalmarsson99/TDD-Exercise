namespace FizzBuzz
{
    public class Kalkylator
    {
        public static string FizzBuzzKalkyl(int nummer)
        {
            if (nummer % 3 == 0)
                return "Fizz";

            else if (nummer % 5 == 0)
                return "Buzz";

            else if (nummer % 3 == 0 && nummer % 5 == 0)
                return "FizzBuzz";

            else
                return $"{nummer}";
        }
    }
}