using FizzBuzz;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FizzBuzz_Test
{
    [TestClass]
    public class KalkylatorTests
    {

        [TestMethod]
        [DynamicData(nameof(MyNumbers))]
        public void FizzBuzzCalculatorReturnValidValue(int randomNumber, string expectedString)
        {
            // Arrange
            //int randomNummer = 25;

            // Act
            string result = Kalkylator.FizzBuzzKalkyl(randomNumber);

            // Assert
            Assert.AreEqual(expectedString, result);
        }

        [TestMethod]
        [DynamicData(nameof(MyNumbers))]
        public void LogMessage_WritesMessageToConsole(int randomNumber, string expectedString)
        {
            //Arrange
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var expected = expectedString;

            //Act
            Kalkylator.LogMessage(randomNumber);
            var actuall = stringWriter.ToString().Trim();

            //Assert
            Assert.AreEqual(expected, actuall);
        }

        [TestMethod]
        [DynamicData(nameof(MyNumbers))]
        public void LogMessage_WritesUserInputMessageToConsole(int randomNumber, string expectedString)
        {
            // Arrange
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var expected = expectedString;

            // Redirect Console.ReadLine to read from a StringReader
            using (StringReader stringReader = new StringReader(randomNumber.ToString()))
            {
                Console.SetIn(stringReader);

                // Act
                Kalkylator.LogMessageFromUserInput();
                var actual = stringWriter.ToString().Trim();

                // Assert
                Assert.AreEqual(expected, actual);
            }
        }

        public static IEnumerable<object[]> MyNumbers
        {
            get
            {
                for (int i = 1150; i <= 1160; i++)
                {
                    string result = "";

                    if (i % 3 == 0)
                        result += "Fizz";

                    if (i % 5 == 0)
                        result += "Buzz";

                    if (i % 7 == 0)
                        result += "Whizz";

                    if (i % 11 == 0)
                        result += "Bang";

                    yield return new object[] { i, result.Length == 0 ? i.ToString() : result };
                }
            }
        }
    }
}