using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._1._Easy
{
    internal class Multiply
    {
        public static double Multiplies(double num1, double num2) 
        {
            double product = num1 * num2;

            return Math.Round(product, 2);
        }
    }
}
//Create a function that takes 2 doubles as a parameters.
//The function should multiply the numbers together then return the value.
//Round the returned value to 2 decimal places.
//Print the rounded value to the console.