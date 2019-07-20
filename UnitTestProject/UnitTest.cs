using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem1;

namespace UnitTestProblem1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestSumGeneral()
        {
            // Arrange
            object[] input = { (int) 12, (long) 10653, (byte) 12, (sbyte) -5,
                         16.3, "string" , (System.Int32)32,  new Tuple <int, string, string>(1, "Julia", "Test")};
            var expectedOutput = 44;

            // Act
            var actualOutput = IntAddition.getSum(input);
            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }


        [TestMethod]
        public void TestSumMaxValue()
        {
            // Arrange
            object[] input = { Int32.MaxValue, 1 };
            long expectedOutput = Int32.MaxValue + (long)1;

            // Act
            var actualOutput = IntAddition.getSum(input);
            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }


        [TestMethod]
        public void TestSumWithNull()
        {
            // Arrange
            object[] input = { Int32.MaxValue, null };
            long expectedOutput = Int32.MaxValue;

            // Act
            var actualOutput = IntAddition.getSum(input);
            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestSumWithNullInput()
        {
            // Arrange
            object[] input = null;
            long expectedOutput = 0;

            // Act
            var actualOutput = IntAddition.getSum(input);
            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }


        [TestMethod]
        public void TestSumWithEmptyArray()
        {
            // Arrange
            object[] input = new object[] { };
            long expectedOutput = 0;

            // Act
            var actualOutput = IntAddition.getSum(input);
            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }


    }
}
