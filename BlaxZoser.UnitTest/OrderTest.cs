using BlaxZoser.Algorithm;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BlaxZoser.UnitTest
{
    public class OrderTest
    {
        [Fact]
        public void ShouldBeOrderWithBubbleSort()
        {
            // arrange
            var testArray = new int[] { 5, 1, 4, 2, 8 };
            var fakeResult = new int[] { 1, 2, 4, 5, 8 };
            var order = new Order();

            // Act
            var resultArray = order.ApplyOrderAscWithBubbleSort(testArray);

            // Assert
            Assert.Equal(resultArray,fakeResult);

        }


        [Fact]
        public void ShouldBeOrderWithRecursiveBubbleSortWithTenElements()
        {
            // arrange
            var testArray = new int[] { 10,9,8,7,6,5,4,3,2,1};
            var fakeResult = new int[] { 1,2,3,4,5,6,7,8,9,10};
            var order = new Order();

            // Act
            order.ApplyRecursiveBubbleSort(testArray, testArray.Length);

            // Assert
            Assert.Equal(testArray, fakeResult);

        }

        [Fact]
        public void ShouldBeOrderWithRecursiveBubbleSort()
        {
            // arrange
            var testArray = new int[] { 5, 1, 4, 2, 8 };
            var fakeResult = new int[] { 1, 2, 4, 5, 8 };
            var order = new Order();

            // Act
             order.ApplyRecursiveBubbleSort(testArray, testArray.Length);

            // Assert
            Assert.Equal(testArray, fakeResult);

        }


        [Fact]
        public void ShouldBeOrderWithBubbleSortWithTenElements()
        {
            // arrange
            var testArray = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var fakeResult = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var order = new Order();

            // Act
            var resultArray = order.ApplyOrderAscWithBubbleSort(testArray);

            // Assert
            Assert.Equal(resultArray, fakeResult);

        }

    }
}
