using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public static double ConvertInputToNumeric(string argTextInput, bool isOperator = false)
        {
            bool converted;
            while (true)
            {
                if (!isOperator) { //if its not an opertor it will go to the below section for numbered inputs
                    converted = double.TryParse(argTextInput, out var result);
                    if (converted) {
                        return result; 
                    } else {
                        Console.WriteLine("Please try again. ");
                        argTextInput = Console.ReadLine();
                    }
                } else {   //else it goes to operator input
                    if (argTextInput == "+" || argTextInput == "-" || argTextInput == "*" ||
                    argTextInput == "/" || argTextInput == "^"){
                        return 0; // Returning 0  to satisfy the return type
                    }
                    else{
                        Console.WriteLine("Invalid operator. Enter a valid operator: (+, -, *, /, ^):");
                        argTextInput = Console.ReadLine(); // Get new input from the user
                    }
                }
            }
        }
    }
}