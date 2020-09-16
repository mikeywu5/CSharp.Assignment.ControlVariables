using System;
using NUnit.Framework;
using CSharp.Tests.Library;
using System.Linq;

namespace Basic.Previous.Tests
{
    public class FibonacciTests
    {
        [TestCase(-1, ExpectedResult = new string[0])]
        [TestCase(0, ExpectedResult = new[] {
            0
        })]
        [TestCase(1, ExpectedResult = new[] {
            0, 1, 1
        })]
        [TestCase(2, ExpectedResult = new[] {
            0, 1, 1, 2
        })]
        [TestCase(3, ExpectedResult = new[] {
            0, 1, 1, 2, 3
        })]
        [TestCase(4, ExpectedResult = new[] {
            0, 1, 1, 2, 3
        })]
        [TestCase(5, ExpectedResult = new[] {
            0, 1, 1, 2, 3, 5
        })]
        [TestCase(10, ExpectedResult = new[] {
            0, 1, 1, 2, 3, 5, 8
        })]
        [TestCase(50, ExpectedResult = new[] {
            0, 1, 1, 2, 3, 5, 8, 13, 21, 34
        })]
        [TestCase(144, ExpectedResult = new[] {
            0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144
        })]
        [TestCase(1000, ExpectedResult = new[] {
            0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987
        })]
        public int[] TestFibonacciNumbers(int lastNumber)
        {
            Action app = new Action(Fibonacci.Main);
            var r = app.Run(lastNumber);
            var actual = r.FetchValues<int>();
            return actual.ToArray();
        }
    }
}
