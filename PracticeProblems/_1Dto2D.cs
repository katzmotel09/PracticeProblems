using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class _1Dto2D
    {
        public static void SingleDimToMultiDim(int[] array, int rows, int columns)
        {
            int index = 0;
            int[,] multi = new int[rows, columns]; // make 2d array

            for (int y = 0; y < rows; y++) // loops through until y = # of rows
            {
                for (int x = 0; x < columns; x++) 
                {
                    multi[y, x] = array[index]; // assigns first row of ints from array, then next row and so on
                    index++;
                    Console.Write(multi[y, x] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
//Create a function that takes one string as a parameter.
//The function should convert a one-dimensional array to a two-dimensional array.
//Print the value to the console.