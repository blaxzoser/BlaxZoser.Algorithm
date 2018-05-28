using BlaxZoser.Algorithm;
using Xunit;

namespace BlaxZoser.UnitTest
{
    public class FaltorialTest
    { 
        [Fact]
        public void CalculateFactorialSmalNumber()
        {
            //Arrage
            var expect = 6;
            var number = 3;
            Factorial factorial = new Factorial();

            //Act
            var result = factorial.Calculate(number);

            //Assert
            Assert.Equal(expect, result);
        }


        [Fact]
        public void CalculateFactorialBigNumber()
        {
            //Arrage
            var expect = 720;
            var number = 6;
            Factorial factorial = new Factorial();

            //Act
            var result = factorial.Calculate(number);

            //Assert
            Assert.Equal(expect, result);
        }

    }
}
