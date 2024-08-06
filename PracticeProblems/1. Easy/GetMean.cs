using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticeProblems._1._Easy
{
    internal class GetMean
    {
        public static double Mean(int[] nums) 
        {
            double length = nums.Length;
            double sum = 0;

            foreach (int i in nums) 
            {
                sum += i;
            }

            return sum / length;
        }
    }
}
//Create a function that takes an array of integers as a parameter.
//Return the mean of the numbers without using the Math function.
//Print the mean to the console.