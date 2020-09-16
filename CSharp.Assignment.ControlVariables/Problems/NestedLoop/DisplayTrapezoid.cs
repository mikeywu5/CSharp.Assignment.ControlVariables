using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.NestedLoop
{
    /// <summary>
    /// Create a console app that reads the number of lines/rows and then a character to be displayed on separate lines. The app will display a trapezoid.
    /// </summary>
    public class DisplayTrapezoid
    {
        public static void Main()
        {
            Console.Error.WriteLine("Enter the number of lines.");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Error.WriteLine("Enter the filling character.");
            char fillChar = Convert.ToChar(Console.ReadLine());

            // write your codes here.
        }
    }
}
