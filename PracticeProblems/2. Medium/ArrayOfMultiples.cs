using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._2._Medium
{
    internal class ArrayOfMultiples
    {
        public static int[] ArrayMultiples(int numMultiply, int numTimesMultiplied) 
        {
            int counter = 1;
            int[] multipliedNums = new int[numTimesMultiplied];

            for (int i = 0; i < multipliedNums.Length; i++) 
            {
                multipliedNums[i] = counter * numMultiply;
                counter++;
            }

            return multipliedNums;
        }
    }
}
//Create a function that takes two integers as parameters.
//The first parameter should be a number to be muliplied.
//The second parameter should be the number of times
//the first parameter will be multipled.
//Return the muliples in an array.
//Print the array values to the console.