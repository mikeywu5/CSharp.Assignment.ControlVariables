using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharp.Tests.Library;
using System.Linq;

namespace Problems.NestedLoop.Tests
{
    class SeriesUpTests
    {
        [TestCase(0, ExpectedResult = new int[0])]
        [TestCase(1, ExpectedResult = new[] { 1 })]
        [TestCase(2, ExpectedResult = new[] { 1, 1, 2 })]
        [TestCase(3, ExpectedResult = new[] { 1, 1, 2, 1, 2, 3 })]
        [TestCase(4, ExpectedResult = new[] { 1, 1, 2, 1, 2, 3, 1, 2, 3, 4 })]
        [TestCase(6, ExpectedResult = new[] { 1, 1, 2, 1, 2, 3, 1, 2, 3, 4, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 6 })]
        public int[] TestSeriesUpTests(int n)
        {
            var app = new Action(SeriesUp.Main);
            string r;
            r = app.Run(n);
            var actual = r.FetchValues<int>().ToArray();
            return actual;
        }
    }
}
