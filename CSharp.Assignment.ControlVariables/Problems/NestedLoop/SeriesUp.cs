using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.NestedLoop
{
    public class SeriesUp
    {
        /// <summary>
        /// Create an app that inputs one number, n >= 0. The app will print out all the numbers [a total of n*(n + 1)/2 numbers] on separate lines. Write the numbers with the following pattern for n = 5: 1     1 2     1 2 3      1 2 3 4      1 2 3 4 5. These extra spaces separate the groupings.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter a number to display a series up.");
            int number = int.Parse(Console.ReadLine());
            // Write your codes here.
        }
    }
}
