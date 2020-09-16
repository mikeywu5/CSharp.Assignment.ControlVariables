using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Product
{
    /// <summary>
    /// Calculate x (decimal) to the y (whole number) power (x^y).
    /// </summary>
    /// <example>
    /// 3^4 = 3*3*3*3 = 81
    /// </example>
    public class Power
    {
        public static void Main()
        {
            Console.Error.WriteLine("Enter the value of x in decimal.");
            decimal x = decimal.Parse(Console.ReadLine());
            Console.Error.WriteLine("Enter the value of y as a whole number.");
            int y = int.Parse(Console.ReadLine());
            Console.Error.WriteLine("The value of x^y is:");
            // Write your loop codes here.
        }
    }
}
