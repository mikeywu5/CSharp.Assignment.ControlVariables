using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class ExponentToAscii
    {
        /// <summary>
        /// Create a console application that takes an input string argument. The string will follow an algebraic expres-sion with exponents, indicated by the character ^. Your task is to display strings like this:
        /// abc^d+ef^g + hijk^l - M^(NO^P) (Ag^+)
        /// Into:
        ///    d   g       l     NO^P    +
        /// abc +ef  + hijk  - M      (Ag )
        /// A few conditions follow below:
        /// 1.	All the letters and digits shall be together in the exponent
        /// 2.	There are special cases with parentheses, and they need to be treated in the exponent.Please run some test cases.
        /// 3.	Ignore the exponent inside an exponent, so you will only need to display one level.
        /// Please execute the test program with your own test cases, i.e.:
        /// </summary>
        public static void Main()
        {
            Console.Error.WriteLine("Write an expression with ^ (Empty to exit).");
            string expression = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(expression)) return;

            // Write your codes here.

            // Here are my recommended control variables you can use.
            string line1 = ""; // top line
            string line2 = ""; // bottom line
            bool inExp = false; // indicates if it's in the exponent.
            int parens = 0; // count the number of parens.
        }
    }
}