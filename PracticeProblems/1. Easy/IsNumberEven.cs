using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._1._Easy
{
    internal class IsNumberEven
    {
        public static bool Even(int num) 
        {
            bool result = false;

            if (num % 2 == 0) 
            {
                result = true;
            }

            return result;
        }
    }
}
//Create a function that takes an integer as a parameter.
//The function should evaluate as to if a number is even.
//Return an boolean value based on if the integer is even.
//Print the value to the console.