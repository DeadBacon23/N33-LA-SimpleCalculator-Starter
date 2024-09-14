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
            string inputNumber = "5";
            double convertedNumber = InputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        public void ConvertsValidDecimalStringInputIntoDouble()
        {
            string inputNumber = "5.75";
            double convertedNumber = InputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(5.75, convertedNumber, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertEmptyStringIntoDouble()
        {
            string inputNumber = "";
            InputConverter.ConvertInputToNumeric(inputNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertNonNumericStringIntoDouble()
        {
            string inputNumber = "abc";
            InputConverter.ConvertInputToNumeric(inputNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertSpecialCharacterStringIntoDouble()
        {
            string inputNumber = "*";
            InputConverter.ConvertInputToNumeric(inputNumber);
        }

        [TestMethod]
        public void ConvertsNegativeStringInputIntoDouble()
        {
            string inputNumber = "-5";
            double convertedNumber = InputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(-5, convertedNumber);
        }

        [TestMethod]
        public void ConvertsStringWithLeadingTrailingSpacesIntoDouble()
        {
            string inputNumber = "  5.5  ";
            double convertedNumber = InputConverter.ConvertInputToNumeric(inputNumber.Trim());
            Assert.AreEqual(5.5, convertedNumber, 0.0001);
        }

        [TestMethod]
        public void ConvertsStringWithDecimalPointIntoDouble()
        {
            string inputNumber = "3.14";
            double convertedNumber = InputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(3.14, convertedNumber, 0.0001);
        }
    }
}
