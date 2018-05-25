using BlaxZoser.Algorithm;
using Xunit;

namespace BlaxZoser.UnitTest
{
    public class PalindromoTest
    {
        [Fact]
        public void ShouldBePalindromo()
        {
            //Arrage
            var fake = "ababa";
            Palindromo palindromo = new Palindromo();

            //Act
            var result = palindromo.Is(fake);

            //Assert
            Assert.True(result);
        }
    }
}