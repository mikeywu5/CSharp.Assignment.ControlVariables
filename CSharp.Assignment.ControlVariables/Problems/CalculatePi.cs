using System;
namespace Problems
{
    /// <summary>
    /// Calculate the value of PI from the infinite Taylor series
    /// pi = 4 - 4/3 + 4/5 - 4/7 + 4/9 - 4/11 + ...
    /// This app prompts for the epsilon, which is the error at which your PI is estimated at (this error can be esimated by the adjacent pairs).
    /// The app will print out the number of iterations +/- 2 required for this accuracy and the final line will be PI.
    /// </summary>
    /// <remarks>
    /// Please use decimal data type because it has 28 or 29 significant figures.
    /// </remarks>
    public class CalculatePi
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number of iterations");
            int n = int.Parse(Console.ReadLine());
            // Write your codes here.
        }
    }
}
