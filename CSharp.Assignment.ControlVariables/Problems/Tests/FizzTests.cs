using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharp.Tests.Library;
using System.Linq;

namespace Problems.Tests
{
    class FizzTests
    {
        [TestCase(5, 10,
            ExpectedResult = new[] { 5, 6, 7, 8, 9 })]

        [TestCase(11, 18,
            ExpectedResult = new[] { 11, 12, 13, 14, 15, 16, 17 })]

        [TestCase(1, 3,
            ExpectedResult = new[] { 1, 2 })]

        [TestCase(1, 2,
            ExpectedResult = new[] { 1 })]

        [TestCase(1, 1,
            ExpectedResult = new int[0])]

        [TestCase(1000, 1005,
            ExpectedResult = new[] { 1000, 1001, 1002, 1003, 1004 })]
        public int[] TestFizz(int start, int end)
        {
            var app = new Action(Fizz.Main);
            var r = app.Run(start, end);
            var actual = r.FetchValues<int>();
            return actual.ToArray();
        }
    }
}