using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Product
{
    /// <summary>
    /// Write codes to calculate the final principal amount (first input) after a certain number of years (second input) with a set interest rate (third input), assuming that each year is a period. In the end, print out the final principal amount.
    /// </summary>
    /// <remarks>
    /// final_principal = principal * (1 - interest_rate) ^ number_of_years, where ^ is the notation for "to the power of".
    /// </remarks>
    public class CompoundInterest
    {
        public static void Main()
        {
            Console.WriteLine("Enter the principal amount");
            decimal principal = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of years");
            // Your codes

            Console.WriteLine("Enter the interest rate");
            // Your codes

            // then calculate and output the final principal amount using the formula,
           
        }
    }
}
