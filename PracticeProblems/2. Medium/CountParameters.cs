using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._2._Medium
{
    internal class CountParameters
    {
        public static int CountParams(params object[] thingies)
        {
            int count = 0; // holds the amount of params as we count

            foreach (object thing in thingies) // loops through each param passed to function
            {
                count++; // updates count accordinglyHard
            }

            return count;
        }
    }
}
//Create a function that counts the amount
//of params passed to the function.