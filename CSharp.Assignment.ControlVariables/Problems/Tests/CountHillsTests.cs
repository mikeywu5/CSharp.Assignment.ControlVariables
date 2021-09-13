using System;
using NUnit.Framework;
using CSharp.Tests.Library;
using System.Text.RegularExpressions;
namespace CSharp.Assignments.ConsoleLoop2.Tests
{
    public class CountHillsTests
    {
        [TestCase(ExpectedResult = 0)]
        [TestCase(0, 2, 1, ExpectedResult = 1)]
        [TestCase(0, 2, 1, 3, ExpectedResult = 1)]
        [TestCase(0, 2, 1, 3, 3, 0, ExpectedResult = 2)]
        [TestCase(3, ExpectedResult = 0)]
        [TestCase(3, 3, ExpectedResult = 0)]
        [TestCase(3, 3, 2, ExpectedResult = 0)]
        [TestCase(3, 3, 2, 2, 1, ExpectedResult = 0)]
        [TestCase(3, 3, 2, 2, 1, 0, ExpectedResult = 0)]
        [TestCase(3, 3, 2, 2, 1, 0, 1, 2, ExpectedResult = 0)]
        [TestCase(3, 3, 2, 2, 1, 0, 1, 2, 1, ExpectedResult = 1)]
        [TestCase(3, 3, 2, 2, 1, 0, 1, 2, 1, 3, ExpectedResult = 1)]
        [TestCase(3, 3, 2, 2, 1, 0, 1, 2, 1, 3, 1, ExpectedResult = 2)]
        [TestCase(3, 3, 2, 2, 1, 0, 1, 2, 1, 3, 1, 5, ExpectedResult = 2)]
        [TestCase(3, 3, 2, 2, 1, 0, 1, 2, 1, 3, 1, 5, 3, ExpectedResult = 3)]
        [TestCase(3, 3, 2, 2, 1, 0, 1, 2, 1, 3, 1, 5, 3, 5, ExpectedResult = 3)]
        [TestCase(3, 3, 2, 2, 1, 0, 1, 2, 1, 3, 1, 5, 3, 5, 6, ExpectedResult = 3)]
        [TestCase(3, 3, 2, 2, 1, 0, 1, 2, 1, 3, 1, 5, 3, 5, 6, 8, ExpectedResult = 3)]
        [TestCase(3, 3, 2, 2, 1, 0, 1, 2, 1, 3, 1, 5, 3, 5, 6, 8, 6, ExpectedResult = 4)]
        [TestCase(3, 3, 2, 2, 1, 0, 1, 2, 1, 3, 1, 5, 3, 5, 6, 8, 6, 4, ExpectedResult = 4)]
        [TestCase(3, 3, 2, 2, 1, 0, 1, 2, 1, 3, 1, 5, 3, 5, 6, 8, 6, 4, 0, ExpectedResult = 4)]
        [TestCase(3, 3, 2, 2, 1, 0, 1, 2, 1, 3, 1, 5, 3, 5, 6, 8, 6, 4, 0, -10, ExpectedResult = 4)]
        public static int TestCountHills(params int[] altitude)
        {
            Action app = new Action(CountHills.Main);
            string actual;
            actual = app.Run(altitude);
            var match = Regex.Match(actual, @"([-]?\d+)", RegexOptions.Singleline | RegexOptions.RightToLeft);
            if (match == null)
            {
                Assert.Fail($"The last number should indicate the number of hills. - {actual}");
                return 0;
            }
            int actualValue = int.Parse(match.Captures[0].Value);
            return actualValue;
        }
    }
}
