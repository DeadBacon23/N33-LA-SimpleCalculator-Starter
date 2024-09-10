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
                //InputConverter inputConverter = new InputConverter();

                // Class to perform actual calculations
                CalcUtilities calculatorEngine = new CalcUtilities();

                Console.WriteLine("Enter a number, then an operation (+, -, *, /, ^), then a number to perform the operation \n");

                Console.Write("number 1: ");
                string first = Console.ReadLine();
                double firstNumber = InputConverter.ConvertInputToNumeric(first);

                Console.Write("operation: ");
                string opInput = Console.ReadLine();
                InputConverter.ConvertInputToNumeric(opInput, isOperator: true);
                string operation = opInput;

                Console.Write("number 2: ");
                string second = Console.ReadLine();
                double secondNumber = InputConverter.ConvertInputToNumeric(second);
                
                double answer = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                if (firstNumber.GetType() == typeof(double) && secondNumber.GetType() == typeof(double))
                {
                    switch (operation)
                    {

                        case "+":
                            Console.WriteLine(String.Format("The value {0:##} plus the value {1:##} is equal to {2:##}", firstNumber, secondNumber, answer));
                            break;

                        case "-":
                            Console.WriteLine(String.Format("The value {0:##} minus the value {1:##} is equal to {2:##}", firstNumber, secondNumber, answer));
                            break;

                        case "*":
                            Console.WriteLine(String.Format("The value {0:##} multiplied by the value {1:##} is equal to {2:##}", firstNumber, secondNumber, answer));
                            break;

                        case "/":
                            Console.WriteLine(String.Format("The value {0:##} divided by the value {1:##} is equal to {2:##}", firstNumber, secondNumber, answer));
                            break;

                        case "^":
                            Console.WriteLine(String.Format("The value {0:##} to the power of {1:##} is equal to {2:##}", firstNumber, secondNumber, answer));
                            break;

                    }

                }
            }
            catch (Exception ex) {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message); }
        
        }
    }
}