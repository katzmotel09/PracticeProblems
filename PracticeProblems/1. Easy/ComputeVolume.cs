using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._1._Easy
{
    internal class ComputeVolume
    {
        public static int Volume(int width, int length, int height) 
        {
            int volume = width * length * height;

            return volume;
        }
    }
}
//Create a function that takes 3 integers as parameters. (width, length, height)
//The function should compute the volume based off the values passed in.
//Print the value to the console.
//Length x Width x Height = Volume