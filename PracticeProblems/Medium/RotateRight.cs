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

            foreach (int i in arr) // prints each num in rotated array to console
            {
                Console.WriteLine(i);
            }
        }
    }
}
//Rotate an array to the right
//To use, call the .rotRight function of RotateRight class
//pass an array of ints to the function