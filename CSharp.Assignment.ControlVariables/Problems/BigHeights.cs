using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    public class BigHeights
    {
        /// <summary>
        /// We have a long integer with each digit representing the altitude along a walking trail. Print out the number of "big" steps for a walk starting from the beginning of the number. We'll say that step is big if it is 3 or more up or down.
        /// </summary>
        /// <param name="heights"></param>
        /// <returns></returns>
        public static void Main()
        {
            Console.WriteLine("Enter a long integer with each digit representing a seqeunce of altitudes along the walking trail.");
            long altitudes = long.Parse(Console.ReadLine());

            // Write your codes using a loop here.
            // In the end, print out the number of big heights in int.
        }
    }
}
