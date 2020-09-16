using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Division
{
	/// <summary>
	/// We'll say that a positive int divides itself if every digit in
	/// the number divides into the number evenly. So for example 128
	/// divides itself since 1, 2, and 8 all divide into 128 evenly.
	/// We'll say that 0 does not divide into anything evenly,
	/// so no number with a 0 digit divides itself. Note: use % to get the
	/// rightmost digit, and / to discard the rightmost digit.
	/// 
	/// The app will prompt for a number and then tests whether that number can be
	/// divided by self. If the number can be divided by self, then the app will
	/// print out either "True" or "False", indicating whether the number
	/// can be divided by self or not.
	/// </summary>
	/// <param name="n"></param>
	/// <returns></returns>
	public class DivideSelf
	{
		public static void Main()
		{
			Console.WriteLine("Enter a number and we will detect whether the number can be divided evenly by its digits.");
			int n = Convert.ToInt32(Console.ReadLine());

		}
	}
}
