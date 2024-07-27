using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class _1Dto2D
    {
        public static int[,] SingleDimToMultiDim(int[] nums, int cols, int rows)
        {
            int[,] converted = new int[cols, rows];

            // Fill the 2D array
            for (int i = 0; i < converted.Length; i++)
            {
                int row = i / cols; // Calculate the row index
                int col = i % cols; // Calculate the column index
                converted[row, col] = nums[i];
            }

            return converted;
        }
    }
}
//Create a function that takes one string as a parameter.
//The function should convert a one-dimensional array to a two-dimensional array.
//Print the value to the console.