using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FillingAnArray
{
    [TestClass]
    public class FillingAnArrayTests
    {
        [TestMethod]
        public void GivenAnArray_ReturnNumbersFrom0To5Minus1()
        {
            //Arrange
            var arrayLength = 5;
            int[] expectedResult = { 0, 1, 2, 3, 4 };
 
            //Act
            var actualResult = ArrayContent.ReturnNumbersFrom0ToNMinus1(arrayLength);

            //Assert
            Assert.AreEqual(expectedResult[0], actualResult[0]);
            Assert.AreEqual(expectedResult[1], actualResult[1]);
            Assert.AreEqual(expectedResult[2], actualResult[2]);
            Assert.AreEqual(expectedResult[3], actualResult[3]);
            Assert.AreEqual(expectedResult[4], actualResult[4]);
        }

        [TestMethod]
        public void GivenAnArray_ReturnNumbersFrom0To10Minus1()
        {
            //Arrange
            var arrayLength = 10;
            int[] expectedResult = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Act
            var actualResult = ArrayContent.ReturnNumbersFrom0ToNMinus1(arrayLength);

            //Assert
            Assert.AreEqual(expectedResult[0], actualResult[0]);
            Assert.AreEqual(expectedResult[1], actualResult[1]);
            Assert.AreEqual(expectedResult[2], actualResult[2]);
            Assert.AreEqual(expectedResult[3], actualResult[3]);
            Assert.AreEqual(expectedResult[4], actualResult[4]);
            Assert.AreEqual(expectedResult[5], actualResult[5]);
            Assert.AreEqual(expectedResult[6], actualResult[6]);
            Assert.AreEqual(expectedResult[7], actualResult[7]);
            Assert.AreEqual(expectedResult[8], actualResult[8]);
            Assert.AreEqual(expectedResult[9], actualResult[9]);
        }

        [TestMethod]
        public void GivenAnArray_ReturnNumbersFromMinus4To0()
        {
            //Arrange
            var arrayLength = 5;
            int[] expectedResult = { -4, -3, -2, -1, 0 };

            //Act
            var actualResult = ArrayContent.ReturnNumbersFromMinusNTo0(arrayLength);

            //Assert
            Assert.AreEqual(expectedResult[0], actualResult[0]);
            Assert.AreEqual(expectedResult[1], actualResult[1]);
            Assert.AreEqual(expectedResult[2], actualResult[2]);
            Assert.AreEqual(expectedResult[3], actualResult[3]);
            Assert.AreEqual(expectedResult[4], actualResult[4]);
        }
        [TestMethod]
        public void GivenAnArray_ReturnNumbersFromMinus9To0()
        {
            //Arrange
            var arrayLength = 10;
            int[] expectedResult = { -9, -8, -7, -6, -5, -4, -3, -2, -1, 0 };

            //Act
            var actualResult = ArrayContent.ReturnNumbersFromMinusNTo0(arrayLength);

            //Assert
            Assert.AreEqual(expectedResult[0], actualResult[0]);
            Assert.AreEqual(expectedResult[1], actualResult[1]);
            Assert.AreEqual(expectedResult[2], actualResult[2]);
            Assert.AreEqual(expectedResult[3], actualResult[3]);
            Assert.AreEqual(expectedResult[4], actualResult[4]);
            Assert.AreEqual(expectedResult[5], actualResult[5]);
            Assert.AreEqual(expectedResult[6], actualResult[6]);
            Assert.AreEqual(expectedResult[7], actualResult[7]);
            Assert.AreEqual(expectedResult[8], actualResult[8]);
            Assert.AreEqual(expectedResult[9], actualResult[9]);
        }
    }
}

