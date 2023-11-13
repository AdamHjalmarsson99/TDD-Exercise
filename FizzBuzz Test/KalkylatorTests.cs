using FizzBuzz;
using System.ComponentModel.DataAnnotations;

namespace FizzBuzz_Test
{
    [TestClass]
    public class KalkylatorTests
    {

        [TestMethod]
        [DataRow(25,"Buzz")]
        [DataRow(30,"FizzBuzz")]
        [DataRow(35,"Buzz")]
        [DataRow(9,"Fizz")]
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
        [DataRow(25, "Buzz")]
        [DataRow(30, "FizzBuzz")]
        [DataRow(35, "Buzz")]
        [DataRow(9, "Fizz")]
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
    }
}