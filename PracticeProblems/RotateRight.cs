using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal static class RotateRight
    {
        public static void rotRight(int[] arr)
        {
            int size = arr.Length; // gets length of array
            int temp; // temporarily holds index in array
            for (int i = 0; i < size - 1; i++) // starts at first index, loops through until i = last index

            {
                temp = arr[i]; // sets temp to first index of array
                arr[i] = arr[i + 1]; // sets first index of array = next index
                arr[i + 1] = temp; // sets next index = temp
            }
        }
    }
}
//Rotate an array to the right
//To use, create an array of ints in main method
//Call the .rotRight function of the RotateRight class.
//Use a foreach loop to print the results.