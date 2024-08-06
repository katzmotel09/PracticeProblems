using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._1._Easy
{
    internal class IsNumberOdd
    {
        public static bool Odd(int num) 
        {
            bool result = false;

            if (num % 2 != 0) 
            {
                result = true;
            }

            return result;
        }
    }
}
//Create a function that takes an integer as a parameter.
//The function should evaluate as to if a number is odd.
//Return an boolean value based on if the integer is odd.
//Print the value to the console.