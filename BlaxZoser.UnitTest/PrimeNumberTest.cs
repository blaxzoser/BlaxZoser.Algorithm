using BlaxZoser.Algorithm;
using Xunit;

namespace BlaxZoser.UnitTest
{
    public class PrimeNumberTest
    {

        [Fact]
        public void ShuldBePrimeNumber()
        {
            //Arrage
            var isPrime = 3;
            PrimeNumber primerNumber = new PrimeNumber();

            //Act
            var result = primerNumber.Is(isPrime);
            

            //Assert
            Assert.True(result);

        }


        [Fact]
        public void ShuldBePrimeNumberWith2()
        {
            //Arrage
            var isPrime = 2;
            PrimeNumber primerNumber = new PrimeNumber();

            //Act
            var result = primerNumber.Is(isPrime);

            //Assert
            Assert.True(result);
        }


        [Fact]
        public void ShuldBeNotPrimeNumber()
        {
            //Arrage
            var isNotPrime = 4;
            PrimeNumber primerNumber = new PrimeNumber();

            //Act
            var result = primerNumber.Is(isNotPrime);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void ShuldBePrimeNumberWithTheoremaWilson()
        {
            //Arrage
            var isPrime = 89;
            Factorial factorial = new Factorial();

            PrimeNumber primerNumber = new PrimeNumber(factorial);

            //Act
            var result = primerNumber.ApplyThehoremaWilson(isPrime);


            //Assert
            Assert.True(result);

        }

    }
}
