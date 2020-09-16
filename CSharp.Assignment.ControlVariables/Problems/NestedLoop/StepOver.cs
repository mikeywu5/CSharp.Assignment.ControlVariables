using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.NestedLoop
{
    /// <summary>
    /// Create a console application that reads the value of n from the input. The app will then write a bunch of numbers as separate lines. These displayed numbers will have the following patterns—for n = 4, the app will print out 1 2 3 4     2 3 4 0   3 4 0 0    4 0 0 0.  Each number will appear in a separate line. The extra spaces separate sets of 4 numbers.
    /// </summary>
    public class StepOver
    {
        public static void Main()
        {
            Console.Error.WriteLine("Enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine());
            // write down your codes here to generate the step over integers.
        }
    }
}
