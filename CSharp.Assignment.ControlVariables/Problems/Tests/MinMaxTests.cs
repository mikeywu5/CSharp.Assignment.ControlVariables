using System;
using NUnit.Framework;
using CSharp.Tests.Library;

namespace Problems.Tests
{
    public class MinMaxTests
    {
        [TestCase(5, ExpectedResult = new[] { 5, 5 })]
        [TestCase(2, 3, 1, ExpectedResult = new[] { 1, 3 })]
        [TestCase(1, 0, -1, ExpectedResult = new[] { -1, 1 })]
        [TestCase(6, 5, 5, 7, 2, 6, 7, -2, -1, -1, -1, -3, 7, 8, 9, -9, 0, -4, 5, -7,
            ExpectedResult = new[] { -9, 9 })]
        public int[] TestMinMax(params int[] input)
        {
            Action app = new Action(MinMax.Main);
            var r = app.Run(input);
            var actual = r.FetchValues<int>();
            Assert.GreaterOrEqual(2, actual.Count, "Two integers are expected to be outputed: minimum (first) then maximum (second).");
            return new[] { actual[actual.Count - 2], actual[actual.Count - 1] };
        }
    }
}
