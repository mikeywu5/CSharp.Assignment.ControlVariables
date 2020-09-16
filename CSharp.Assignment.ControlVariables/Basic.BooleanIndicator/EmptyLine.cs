using System;

namespace Basic.BooleanIndicator
{
    /// <summary>
    /// Determine whether you have entered an empty line (i.e. an empty string "").
    /// In the end, print out the word, "blank", if you have entered an empty line.
    /// </summary>
    public class EmptyLine
    {
        public static void Main()
        {
            // Enter a sequence of lines until you have reached the end of line.
            // Print out "blank" only once at the end.
            Console.Error.WriteLine("Please enter some lines on separate lines (CTRL-Z) to exit.");
            bool hasEmptyLine;
        }
    }
}
