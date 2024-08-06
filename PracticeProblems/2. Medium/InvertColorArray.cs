using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._2._Medium
{
    internal class InvertColorArray
    {
        public static int[] InvertColor(int[] colorArray) 
        {
            int[] invertedColorArray = new int[3]; // create array of side 3 to hold inverted values

            // find inverted value by subtracting 255 and getting absolute value
            double invertedValueZero = Math.Abs(colorArray[0] - 255); // invert first array index
            double invertedValueOne = Math.Abs(colorArray[1] - 255); // invert second array index
            double invertedValueTwo = Math.Abs(colorArray[2] - 255); // invert third array index

            // convert inverted values to int
            invertedColorArray[0] = Convert.ToInt32(invertedValueZero); 
            invertedColorArray[1] = Convert.ToInt32(invertedValueOne);
            invertedColorArray[2] = Convert.ToInt32(invertedValueTwo);

            return invertedColorArray;
        }
    }
}
//Create a function that takes one integer array as a parameter.
//The function should invert the colors assuming a range of 255 colors.
//Print the values to the console.
//RGB = (R*65536)+(G*256)+B , (when R is RED, G is GREEN and B is BLUE)