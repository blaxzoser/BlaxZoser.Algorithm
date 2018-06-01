using BlaxZoser.Algorithm;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BlaxZoser.UnitTest
{
    public class FindTest
    {
        [Fact]
        public void ShouldFindSmallestValueX()
        {
            // arrange
            var testArray = new int[] { 5, 1, 4, 2, 8 };
            var index = 3;
            var result = 5;

            var order = new Find();

            // Act
            var resultArray = order.GetNumberSmallestByIndex(testArray, index);

            // Assert
            Assert.Equal(result, resultArray);

        }

        [Fact]
        public void ShouldFindLargetestValueX()
        {
            // arrange
            var testArray = new int[] { 5, 1, 4, 2, 8 };
            var index = 1;
            var result = 8;

            var order = new Find();

            // Act
            var resultArray = order.GetNumberLargestByIndex(testArray, index - 1);

            // Assert
            Assert.Equal(result, resultArray);

        }

        [Fact]
        public void ShouldGetNumbersRepeat2OnlyNumbers()
        {
            // arrange
            var testArray = new int[] { 4, 2, 4, 5, 2, 3, 1 };
            var fakeResult = new int[] { 4, 2 };
            var order = new Find();

            // Act
            var resultArray = order.GetRepeatNumber(testArray, testArray.Length);

            // Assert
            Assert.Equal(resultArray, fakeResult);

        }



        [Fact]
        public void ShouldGetNumbersRepeatN()
        {
            // arrange
            var testArray = new int[] { 7,1, 2, 3, 1, 3, 6, 6 }; ;
            var fakeResult = new int[] { 1 , 3 , 6,0,0,0,0,0 };
            var order = new Find();

            // Act
            var resultArray = order.GetRepeatNumberN(testArray);

            // Assert
            Assert.Equal(fakeResult, resultArray);

        }

    }
}
