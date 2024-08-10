using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._2._Medium
{
    internal class MultiplyArrayByLength
    {
        public static int[] MultiplyArray(int[] nums) 
        {
            int length = nums.Length;
            int counter = 0;

            foreach (int i in nums) 
            {
                nums[counter] = length * i;
                counter++;
            }

            return nums;
        }
    }
}
//Create a function that takes one integer array as a parameter.
//The function should multiply each value of the array by the length of the array the return the array.
//Print the values to the console.