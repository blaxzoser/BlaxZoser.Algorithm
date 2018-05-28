using BlaxZoser.Algorithm;
using Xunit;

namespace BlaxZoser.UnitTest
{
    public class PalindromoTest
    {
        [Fact]
        public void ShouldBePalindromoWithSimpleWord()
        {
            //Arrage
            var fake = "ababa";
            Palindromo palindromo = new Palindromo();

            //Act
            var result = palindromo.Calculate(fake);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void ShouldBeNotPalindromoWithSimpleWord()
        {
            //Arrage
            var fake = "ababas";
            Palindromo palindromo = new Palindromo();

            //Act
            var result = palindromo.Calculate(fake);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void ShouldBePalindromoWithComplexWord()
        {
            //Arrage
            var fake = "a ti no bonita";
            Palindromo palindromo = new Palindromo();

            //Act
            var result = palindromo.Calculate(fake);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void ShouldBePalindromoWithComplexWordAndWithUpper()
        {
            //Arrage
            var fake = "A ti no bonita";
            Palindromo palindromo = new Palindromo();

            //Act
            var result = palindromo.Calculate(fake);

            //Assert
            Assert.True(result);
        }

    }
}
