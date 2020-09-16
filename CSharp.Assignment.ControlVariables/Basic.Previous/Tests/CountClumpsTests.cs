using System;
using NUnit.Framework;
using CSharp.Tests.Library;
using System.Linq;

namespace Basic.Previous.Tests
{
    public class CountClumpsTests
    {
        [TestCase(1, 2, 2, 3, 4, 4, ExpectedResult = 2)]
        [TestCase(1, 1, 2, 1, 1, ExpectedResult = 2)]
        [TestCase(1, 1, 1, 1, 1, ExpectedResult = 1)]
        [TestCase(1, 2, 3, ExpectedResult = 0)]
        [TestCase(2, 2, 1, 1, 1, 2, 1, 1, 2, 2, ExpectedResult = 4)]
        [TestCase(0, 2, 2, 1, 1, 1, 2, 1, 1, 2, 2, ExpectedResult = 4)]
        [TestCase(0, 0, 2, 2, 1, 1, 1, 2, 1, 1, 2, 2, ExpectedResult = 5)]
        [TestCase(0, 0, 0, 2, 2, 1, 1, 1, 2, 1, 1, 2, 2, ExpectedResult = 5)]
        public int TestCountClumps(params int[] input)
        {
            Action app = new Action(CountClumps.Main);
            var r = app.Run(input);
            int actual = r.FetchValue<int>();
            return actual;
        }
    }
}
