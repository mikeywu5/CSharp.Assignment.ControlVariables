using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    /// <summary>
    /// Create a console application that reads a sequence of integers (they can be positive, negative, or zero) from the input. Do not use built-in functions or arrays to implement the logic. Perform the following tasks in each iteration:
    ///    (1)	The app will sum up sequential evens or sequential odds—whichever the sequence the input values are in. Code number%2==0 can be used to determine whether a number is even or not.In general, sequential evens are even numbers that are together, and vice versa.
    ///    (2)	When the input changes from even to odd or from odd to even OR when the iteration has terminated with CTRL-Z as an input(when the ReadLine() method returns a null), the app will display the sum calculated in Task 1.
    ///    (3)	The app will identify the largest sum of sequential odds as well as the largest sum of sequential evens.
    ///    (4)  When the app reaches the end-of-line with CTRL-Z as an input(when the ReadLine() method returns a null), the app will terminate and display the positive difference between the largest sum of sequential odds and the largest sum of sequential evens, calculated in Task 3.
    /// </summary>
    /// <remarks>
    /// For example, the inputs 2, 4, 6, 8, 1, 3, 5, 7 have sequential evens of 2, 4, 6, 8 and sequential odds of 1, 3, 5, 7. When you enter a "1" here, the app will display "The sum is 20" because the input has been changed from even (8) to odd (1). In the end, the app will display "The sum is 16" and then "The positive difference between the largest sums is 4" because of 2+4+6+8 - (1+3+5+7).
    /// </remarks>
    public class LargestEvensOdds
    {
        public static void Main()
        {
            // Write your codes here.
            // Identify which control variables do you need and what are their initial values.
            // Go over the PDF for more info.
        }
    }
}
