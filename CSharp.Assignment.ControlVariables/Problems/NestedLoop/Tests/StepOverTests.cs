using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharp.Tests.Library;
using System.Linq;

namespace Problems.NestedLoop.Tests
{
    class StepOverTests
    {

        [TestCase(0, ExpectedResult = new int[0])]
        [TestCase(1, ExpectedResult = new[] { 1 })]
        [TestCase(2, ExpectedResult = new[] { 1, 2, 2, 0 })]
        [TestCase(3, ExpectedResult = new[] { 1, 2, 3, 2, 3, 0, 3, 0, 0 })]
        [TestCase(4, ExpectedResult = new[] { 1, 2, 3, 4, 2, 3, 4, 0, 3, 4, 0, 0, 4, 0, 0, 0 })]
        [TestCase(6, ExpectedResult = new[] { 1, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 0, 3, 4, 5, 6, 0, 0, 4, 5, 6, 0, 0, 0, 5, 6, 0, 0, 0, 0, 6, 0, 0, 0, 0, 0 })]
        [Category("Nested Loop")]

        public int[] TestStepOver(int size)
        {
            var app = new Action(StepOver.Main);
            string r;
            r = app.Run(size);
            var actual = r.FetchValues<int>().ToArray();
            return actual;
        }
    }
}