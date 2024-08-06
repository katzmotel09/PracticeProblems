using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._1._Easy
{
    internal class AbsoluteValue
    {
        public static int AbsValue(int[] nums) 
        {
            int sum = 0;

            foreach (int i in nums) 
            {
                sum += Math.Abs(i);
            }

            return sum;
        }
    }
}
//Create a function that takes an array of numbers as a parameter. 
//(The values can be positive or negative or both).
//Return the absolute value of each element as a sum of the values.
//Print the sum to the console.