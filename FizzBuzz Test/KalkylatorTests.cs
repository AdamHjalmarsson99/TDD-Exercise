using FizzBuzz;

namespace FizzBuzz_Test
{
    [TestClass]
    public class KalkylatorTests
    {
        //[TestMethod]
        //[ExpectedException(typeof(NotImplementedException))]
        //public void N�r_FizzBuzzKalkyl_EjImplementerad_Then_ShouldThrow_NotImplementedException()
        //{
        //    // Arrange
        //    int randomNummer = 0;

        //    // Act
        //    Kalkylator.FizzBuzzKalkyl(randomNummer);

        //    // Testet kommer att bli gr�nt d� ett NotImplementedException kastas
        //}

        [TestMethod]
        [DataRow]
        [DataRow]
        [DataRow]
        [DataRow]
        public void N�r_FizzBuzzKalkyl_Retrurnerar_Valid_Nummer()
        {
            // Arrange
            int randomNummer = 25;

            // Act
            string result = Kalkylator.FizzBuzzKalkyl(randomNummer);

            // Assert
            Assert.AreEqual("Buzz", result);
        }
    }
}