using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems.Easy
{
    internal class GetMinAndMaxOfArray
    {
        public static int[] MinMax(int[] nums) 
        {
            int[] results = new int[2];

            results[0] = nums.Min();
            results[1] = nums.Max();

            return results;
        }
    }
}
//Create a function that takes an array of ints as a parameter.
//Return the min and the max value from the array as an array of 
//length 2, with the values formatted as {min, max}.
//Print the max and min values to the console.