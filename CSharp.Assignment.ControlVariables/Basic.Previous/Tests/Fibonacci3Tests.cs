using System;
using NUnit.Framework;
using CSharp.Tests.Library;
using System.Linq;

namespace Basic.Previous.Tests
{
    public class Fibonacci3Tests
    {
        [TestCase(-1, ExpectedResult = new string[0])]
        [TestCase(0, ExpectedResult = new[] {
            0
        })]
        [TestCase(1, ExpectedResult = new[] {
            0, 1, 1
        })]

        [TestCase(100000, ExpectedResult = new[] {
            0, 1, 1, 3, 5, 9, 17, 31, 57, 105, 193, 355, 653, 1201, 2209, 4063, 7473, 13745, 25281, 46499, 85525
        })]

        [TestCase(105, ExpectedResult = new[] {
            0, 1, 1, 3, 5, 9, 17, 31, 57, 105
        })]
        public int[] TestFibonacciNumbers(int lastNumber)
        {
            Action app = new Action(Fibonacci3.Main);
            var r = app.Run(lastNumber);
            var actual = r.FetchValues<int>();
            return actual.ToArray();
        }
    }
}
