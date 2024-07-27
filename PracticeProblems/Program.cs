using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            RotateRight.rotRight(new int[] {1, 2, 3, 4, 5});
        }
    }
}
//Create a function that takes one int array as a parameter.
//The function should perform Left circular rotation of an array.
//Print the value to the console.