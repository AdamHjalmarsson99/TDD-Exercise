using FizzBuzz;
using System.IO;

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

        public static IEnumerable<object[]> MyNumbers => new[]
        {
            new object[] { 1, "1" },
            new object[] { 2, "2" },
            new object[] { 3, "Fizz" },
            new object[] { 4, "4" },
            new object[] { 5, "Buzz" },
            new object[] { 6, "Fizz" },
            new object[] { 7, "7" },
            new object[] { 8, "8" },
            new object[] { 9, "Fizz" },
            new object[] { 10, "Buzz" },
            new object[] { 11, "11" },
            new object[] { 12, "Fizz" },
            new object[] { 13, "13" },
            new object[] { 14, "14" },
            new object[] { 15, "FizzBuzz" },
        };
    }
}