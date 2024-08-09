using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._1._Easy
{
    internal class AreaOfTriangle
    {
        public static double Triangle(double b, double h) 
        {
            double half = 1.5;
            double area = half * b * h;

            return Math.Round(area, 2);
        }
    }
}
//Create a function that takes two doubles as a parameters.
//The function should compute the area of a triangle given these two values.
//Print the value to the console.
//A = 1/2 × b × h