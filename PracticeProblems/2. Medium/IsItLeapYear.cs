using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class IsItLeapYear
    {
        public static bool IsLeapYear(int year) 
        {
            bool result = false;

            if (year % 4 == 0) // if year divisble by 4, set result true
            {
                result = true;

                if (year % 100 == 0) // if divisible by 100, set false
                {
                    result = false;

                    if (year % 400 == 0) // if divisble by 400, set back to true
                    {
                        result = true;
                    }
                }
            }

            return result;
        }
    }
}
//Create a function that takes one integer as a parameter. (year)
//The function should evaluate if the year passed in is a Leap year. You can find the formula below.
//Print the value to the console.
