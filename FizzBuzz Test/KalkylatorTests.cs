using FizzBuzz;

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
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        public void FizzBuzzKalkylOutput(int randomNumber)
        {
            int result = Kalkylator.FizzBuzzCalculatorOutput(randomNumber);

            Assert.AreEqual(randomNumber, result);
        }

        [TestMethod]
        public void LogMessage_WritesMessageToConsole()
        {
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var expected = "Service AuthService: Login successful";

            LogMessage("AuthService", "Login successful");
            var actuall = stringWriter.ToString().Trim();

            Assert.AreEqual(expected, actuall);
        }
    }
}