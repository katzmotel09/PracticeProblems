using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._1._Easy
{
    internal class AgeToDays
    {
        public static double AgeDays(int age) 
        {
            double calendarYear = 365.25;
            double result = calendarYear * age;

            return Math.Round(result, 2);
        }
    }
}
//Write a function to convert an age to days.
//Print the result to the console with string interpolation.