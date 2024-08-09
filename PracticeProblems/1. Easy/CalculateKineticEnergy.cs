using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems._1._Easy
{
    internal class CalculateKineticEnergy
    {
        public static int Energy(int mass, int velocity) 
        {
            int squaredVelocity = velocity * velocity;
            int kineticEnergy =  (mass * squaredVelocity) / 2;

            return kineticEnergy;
        }
    }
}
//Create a function that takes two integers as a parameters. (mass, velocity)
//The function should return the kinetic energy given mass and velocity.
//Print the value to the console.
//1/2 m v2