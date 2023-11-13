using FizzBuzz;

namespace FizzBuzz_Test
{
    [TestClass]
    public class KalkylatorTests
    {
        //[TestMethod]
        //[ExpectedException(typeof(NotImplementedException))]
        //public void När_FizzBuzzKalkyl_EjImplementerad_Then_ShouldThrow_NotImplementedException()
        //{
        //    // Arrange
        //    int randomNummer = 0;

        //    // Act
        //    Kalkylator.FizzBuzzKalkyl(randomNummer);

        //    // Testet kommer att bli grönt då ett NotImplementedException kastas
        //}

        [TestMethod]
        [DataRow(25,"Buzz")]
        [DataRow(30,"FizzBuzz")]
        [DataRow(35,"Buzz")]
        [DataRow(9,"Fizz")]
        public void När_FizzBuzzKalkyl_Retrurnerar_Valid_Nummer(int randomNummer, string expectedstring)
        {
            // Arrange
            //int randomNummer = 25;

            // Act
            string result = Kalkylator.FizzBuzzKalkyl(randomNummer);

            // Assert
            Assert.AreEqual(expectedstring, result);
        }
    }
}