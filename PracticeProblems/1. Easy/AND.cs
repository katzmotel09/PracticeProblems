using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._1._Easy
{
    internal class AND
    {
        public static bool And(int num1, int num2) 
        {
            bool result = false;
            bool value1 = Convert.ToBoolean(num1);
            bool value2 = Convert.ToBoolean(num2);

            if (value1 && value2) 
            {
                result = true;
            }

            return result;
        }
    }
}
//Create a function that takes 2 integers as a parameters. (The values can range from 0 to 1.)
//The function should evaluate if both numbers are true.
//Print the value to the console.