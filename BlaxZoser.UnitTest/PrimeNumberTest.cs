using BlaxZoser.Algorithm;
using Xunit;

namespace BlaxZoser.UnitTest
{
    public class PrimeNumberTest
    {  

        [Fact] 
        public void ShouldBePrimeNumber()  
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
        public void ShouldBePrimeNumberWith2()
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
        public void ShouldBeNotPrimeNumber()
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
        public void ShouldBePrimeNumberWithTheoremaWilson()
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

        [Fact]
        public void ShouldGiveXPrimeNumbers()
        {
            //Arrage
            var array = new int[] { 2,3,5,7 };
            PrimeNumber primerNumber = new PrimeNumber();

            //Act
            var result = primerNumber.GiveAll(4);

            //Assert
            Assert.Equal(array, result);
        }



        [Fact]
        public void ShouldBePrimeAnotherMethod()
        {
            //Arrage
            var isPrime = 3;
            PrimeNumber primerNumber = new PrimeNumber();

            //Act
            var result = primerNumber.IsPrime(isPrime);


            //Assert
            Assert.True(result);

        }


        [Fact]
        public void ShouldBeNotPrimeAnotherMethod()
        {
            //Arrage
            var isPrime = 4;
            PrimeNumber primerNumber = new PrimeNumber();

            //Act
            var result = primerNumber.IsPrime(isPrime);


            //Assert
            Assert.False(result);

        }
    }
}
