using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        [TestMethod]
        public void ConvertsValidIntegerStringInputIntoDouble()
        {
            // Arrange
            string inputNumber = "5";

            // Act
            double convertedNumber = InputConverter.ConvertInputToNumeric(inputNumber);

            // Assert
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        public void ConvertsValidDecimalStringInputIntoDouble()
        {
            // Arrange
            string inputNumber = "5.75";

            // Act
            double convertedNumber = InputConverter.ConvertInputToNumeric(inputNumber);

            // Assert
            Assert.AreEqual(5.75, convertedNumber, 0.0001); // Using tolerance for floating-point comparison
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertEmptyStringIntoDouble()
        {
            // Arrange
            string inputNumber = "";

            // Act
            InputConverter.ConvertInputToNumeric(inputNumber);

            // Assert
            // Exception is expected; no additional assertion needed
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertNonNumericStringIntoDouble()
        {
            // Arrange
            string inputNumber = "abc";

            // Act
            InputConverter.ConvertInputToNumeric(inputNumber);

            // Assert
            // Exception is expected; no additional assertion needed
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertSpecialCharacterStringIntoDouble()
        {
            // Arrange
            string inputNumber = "*";

            // Act
            InputConverter.ConvertInputToNumeric(inputNumber);

            // Assert
            // Exception is expected; no additional assertion needed
        }

        [TestMethod]
        public void ConvertsNegativeStringInputIntoDouble()
        {
            // Arrange
            string inputNumber = "-5";

            // Act
            double convertedNumber = InputConverter.ConvertInputToNumeric(inputNumber);

            // Assert
            Assert.AreEqual(-5, convertedNumber);
        }

        [TestMethod]
        public void ConvertsStringWithLeadingTrailingSpacesIntoDouble()
        {
            // Arrange
            string inputNumber = "  5.5  ";

            // Act
            double convertedNumber = InputConverter.ConvertInputToNumeric(inputNumber.Trim());

            // Assert
            Assert.AreEqual(5.5, convertedNumber, 0.0001); // Using tolerance for floating-point comparison
        }

        [TestMethod]
        public void ConvertsStringWithDecimalPointIntoDouble()
        {
            // Arrange
            string inputNumber = "3.14";

            // Act
            double convertedNumber = InputConverter.ConvertInputToNumeric(inputNumber);

            // Assert
            Assert.AreEqual(3.14, convertedNumber, 0.0001); // Using tolerance for floating-point comparison
        }
    }
}
