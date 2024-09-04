using System;
using CalcLibrary;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Class to convert user input
                InputConverter inputConverter = new InputConverter();

                // Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();


                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                if (operation == "+")
                {
                    Console.WriteLine(String.Format("The value {0} plus the value {0} is equal to {0}", firstNumber, secondNumber, result));
                }
                else if (operation == "-")
                {
                    Console.WriteLine(String.Format("The value {0} minus the value {0} is equal to {0}", firstNumber, secondNumber, result));
                }
                else if (operation == "*")
                {
                    // Normally, we'd log this error to a file.
                    Console.WriteLine(ex.Message);   
            }
            finally { }
    }
    }
}