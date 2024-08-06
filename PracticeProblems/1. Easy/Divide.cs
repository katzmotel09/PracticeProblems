using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._1._Easy
{
    internal class Divide
    {
        public static double Divides(double num1, double num2) 
        {
            double result = num1 / num2;

            return Math.Round(result, 2);
        }
    }
}
//Create a function that takes 2 doubles as a parameters.
//The function should divide the numbers then return the value.
//Round the returned value to 2 decimal places.
//Print the rounded value to the console.