using System;

namespace Problems
{
    /// <summary>
    /// Create a console application that prompts you to enter integers continuously
    /// until you have entered the same number thrice (e.g. three times as our sentinel).
    /// We may assume that all the integers we’ve entered are less than 5 digits long.
    /// Hence, we only need to use the int data type. The application will do the following tasks.
    ///    1)  Count the number of Pythagorean triples of any three numbers entered in sequence, such that the square of one number is exactly the same as the sum of the two other squares.
    ///    2)  Identify the largest hypotenuse of the Pythagorean triples found. A hypotenuse is simply the largest absolute number in the Pythagorean Triples.
    ///    3)  Sum up all the numbers (including the sentinel values) that are not part of any Pythagorean triples.
    ///    4)  The application will end when the user has typed three consecutive numbers.
    /// When the app ends, the app will display
    ///    a)  the number of Pythagorean triples from Task 1, 
    ///    b)  the largest hypotenuse from Task 2, and
    ///    c)  the non-Pythagorean sum from Task 3.
    /// </summary>
    public class PythagoreanTriplesContinuous
    {
        public static void Main()
        {
            // Identify your control variables -- you will need some maxes, counts, sums.
            int pythagorean = 0;
            int max = 0;
            int sum = 0;

            // Write your codes here. //
            // Go over the PDF for more info.

            Console.WriteLine($"The number of Pythagorean Triples entered so far is {pythagorean}.");
            Console.WriteLine($"The Largest Hypotenuse in all the Pythagorean Triples is {max}.");
            Console.WriteLine($"The Non-Pythagorean Sum is {sum}.");
        }
    }
}
