using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    /// <summary>
    /// Create a console app that reads the start and end numbers. The app will print out a sequence of integers from start up to but not including end, so for start=5 and end=10, the app will output 5, 6, 7, 8, 9 on separate lines. The end number will be greater or equal to the start number.
    /// </summary>
    public class Fizz
    {
        public static void Main()
        {
            Console.Error.WriteLine("Enter the start number.");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Error.WriteLine("Enter the end number.");
            int end = Convert.ToInt32(Console.ReadLine());

            // Write your codes here.
        }
    }
}
