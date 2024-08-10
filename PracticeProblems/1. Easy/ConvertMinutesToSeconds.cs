using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._1._Easy
{
    internal class ConvertMinutesToSeconds
    {
        public static int MinToSec(int min) 
        {
            int result = min * 60;

            return result;
        }
    }
}
//Create a function that takes a int as a parameter.
//The function should convert the number of minutes passed in to seconds.
//Return the minutes converted to seconds.
//Print the value to the console.