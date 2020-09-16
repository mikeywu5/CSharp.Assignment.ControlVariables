using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.BooleanIndicator
{
    /// <summary>
    /// Enter a line to be matched. Then, enter a sequence of lines. While you are entering a sequence of lines, print out the word, "matched", only once if you have matched the initial line to be matched with the line you are entering.
    /// </summary>
    public class LineIndicator
    {
        public static void Main()
        {
            Console.WriteLine("Enter the line to match against.");
            string lineMatched = Console.ReadLine();

            // Create a loop that allows you to enter a sequence of texts until you have reached the end of the line.
            // While you are entering a line, print out the word "matched" only once when a line matches with your lineMatched.
        }
    }
}
