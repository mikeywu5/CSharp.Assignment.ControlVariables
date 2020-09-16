using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Division
{
    /// <summary>
    /// Determine whether a number is divisible by 11 by repeatedly taking the sum of all the differences of two adjacent digits, without using the modulo of 11.
    /// </summary>
    /// <example>
    /// The number 15763 is divisible by 11 because 3-6+7-5+1 = 0, which is divisible by 11.
    /// </example>
    /// <remarks>
    /// Since 11 is two digits, you will need to check two digits (0, 11, 22, 33, 44, 55, 66, 77, 88, and 99).
    /// For 18-digit long integer, you don't need to use a nested loop to calculate this because even if you have 90909090, repeating for 22 digits (which exceeds 18 digits), the sum is ONLY 99.
    /// </remarks>
    public class DivisibleByEleven
    {
        public static void Main()
        {
            Console.Error.WriteLine("Enter a number");
            long n = long.Parse(Console.ReadLine());
            // Determine whether n is divisible by 11 without using n%11.
        }
    }
}
