using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Summing
{
    /// <summary>
    /// Print out the average of n scores between 0 and 100 (whole numbers, including both 0 and 100) entered until the end of line is reached, ignoring all the scores outside the range. If there are no valid scores entered, the average will be zero.
    /// </summary>
    public class Average
    {
        public static void Main()
        {
            Console.Error.WriteLine("How many number of scores are you going to average?");
            int n = int.Parse(Console.ReadLine());
            // Write your loop here.
        }
    }
}
