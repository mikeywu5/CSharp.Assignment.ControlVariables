using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Division
{
    /// <summary>
    /// Determine whether a number is divisible by 3 by adding up all its digits repeatedly, without using the modulo of 3.
    /// </summary>
    public class DivisibleByThree
    {
        public static void Main()
        {
            Console.Error.WriteLine("Enter a number");
            long n = long.Parse(Console.ReadLine());
            // using nested loop, determine whether n is divisible by 3 without using n%3.
        }
    }
}
