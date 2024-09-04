using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("add", number1, number2);
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("+", number1, number2);
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void SubstractTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 3;
            double result = _calculatorEngine.Calculate("-", number2, number1);
            Assert.AreEqual(2, result);

        }

        [TestMethod]
        public void SubstractTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 3;
            double result = _calculatorEngine.Calculate("minus", number2, number1);
            Assert.AreEqual(2, result);

        }

        [TestMethod]
        public void MultiplyTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 3;
            double result = _calculatorEngine.Calculate("*", number2, number1);
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void MultiplyTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 3;
            double result = _calculatorEngine.Calculate("multiplied", number2, number1);
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void DivideTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 2;
            int number2 = 4;
            double result = _calculatorEngine.Calculate("/", number2, number1);
            Assert.AreEqual(2, result);

        }

        [TestMethod]
        public void DivideTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 2;
            int number2 = 4;
            double result = _calculatorEngine.Calculate("divide", number2, number1);
            Assert.AreEqual(2, result);

        }

        [TestMethod]
        public void PowerOfTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 2;
            int number2 = 4;
            double result = _calculatorEngine.Calculate("^", number2, number1);
            Assert.AreEqual(16, result);

        }

        [TestMethod]
        public void PowerOfTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 2;
            int number2 = 4;
            double result = _calculatorEngine.Calculate("power", number2, number1);
            Assert.AreEqual(16, result);

        }
    }
}
