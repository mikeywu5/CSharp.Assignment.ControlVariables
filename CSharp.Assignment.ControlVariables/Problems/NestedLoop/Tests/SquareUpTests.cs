using System;
using NUnit.Framework;
using System.Text.RegularExpressions;
using CSharp.Tests.Library;
using System.Linq;

namespace Problems.NestedLoop.Tests
{
    public class SquareUpTests
    {
        [TestCase(0, ExpectedResult = new int[0])]
        [TestCase(1, ExpectedResult = new[] { 1 })]
        [TestCase(2, ExpectedResult = new[] { 0, 1, 2, 1 })]
        [TestCase(3, ExpectedResult = new[] { 0, 0, 1, 0, 2, 1, 3, 2, 1 })]
        [TestCase(4, ExpectedResult = new[] { 0, 0, 0, 1, 0, 0, 2, 1, 0, 3, 2, 1, 4, 3, 2, 1 })]
        [TestCase(6, ExpectedResult = new[] { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 2, 1, 0, 0, 0, 3, 2, 1, 0, 0, 4, 3, 2, 1, 0, 5, 4, 3, 2, 1, 6, 5, 4, 3, 2, 1 })]
        [Category("Nested Loop")]

        public int[] TestSquareUp(int size)
        {
            var app = new Action(SquareUp.Main);
            string r;
            r = app.Run(size);
            var actual = r.FetchValues<int>().ToArray();
            return actual;
        }
    }
}
