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
                double value;
                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                if () {
                switch (operation) {

                    case "+": 
                        Console.WriteLine(String.Format("The value {0:##} plus the value {0:##} is equal to {0:##}", firstNumber, secondNumber, result));
                        break;

                    case "-":
                        Console.WriteLine(String.Format("The value {0:##} plus the value {0:##} is equal to {0:##}", firstNumber, secondNumber, result));
                        break;

                    case "*":
                        Console.WriteLine(String.Format("The value {0:##} multiplied by the value {0:##} is equal to {0:##}", firstNumber, secondNumber, result));
                        break;

                    case "/":
                        Console.WriteLine(String.Format("The value {0:##} devide by the value {0:##} is equal to {0:##}", firstNumber, secondNumber, result));
                        break;

            }

            }
            catch (Exception ex) {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message); }
        
        }
    }
}