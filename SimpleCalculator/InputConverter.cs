using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public static double ConvertInputToNumeric(string argTextInput)
        {
            bool converted;
            while (true)
            {
                // use tryparse
                converted = double.TryParse(argTextInput, out var result);
                if (converted) {
                    return result; 
                } else {
                    Console.WriteLine("Please try again.");
                }
            }
        }
    }
}