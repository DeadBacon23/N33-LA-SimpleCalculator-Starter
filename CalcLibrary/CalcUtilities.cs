using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
    public class CalcUtilities
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;
            switch (argOperation)
            {

                case "+":
                    result = argFirstNumber + argSecondNumber;
                    break;

                case "-":
                    result = argFirstNumber - argSecondNumber;
                    break;

                case "*":
                    result = argFirstNumber * argSecondNumber;
                    break;

                case "/":
                    result = argFirstNumber / argSecondNumber;
                    break;

                case "^":
                    result = Math.Pow(argFirstNumber, argSecondNumber);
                    break;
            }
            return result;
        }
    }
}
