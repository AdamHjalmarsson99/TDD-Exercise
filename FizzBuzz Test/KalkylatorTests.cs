using FizzBuzz;

namespace FizzBuzz_Test
{
    [TestClass]
    public class KalkylatorTests
    {
        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void När_FizzBuzzKalkyl_EjImplementerad_Then_ShouldThrow_NotImplementedException()
        {
            // Arrange
            int randomNummer = 0;

            // Act
            Kalkylator.FizzBuzzKalkyl(randomNummer);

            // Testet kommer att bli grönt då ett NotImplementedException kastas
        }

        [TestMethod]
        public void När_FizzBuzzKalkyl_Retrurnerar_Valid_Nummer()
        {
            // Arrange
            int randomNummer = 9;

            // Act
            string result = Kalkylator.FizzBuzzKalkyl(randomNummer);

            // Assert
            Assert.AreEqual("Fizz", result);
        }
    }
}