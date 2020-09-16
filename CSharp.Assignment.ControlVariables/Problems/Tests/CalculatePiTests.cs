using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharp.Tests.Library;

namespace Problems.Tests
{
    class CalculatePiTests
    {
        [TestCase(1, ExpectedResult = "4.00000")]
        [TestCase(5, ExpectedResult = "3.33968")]
        [TestCase(10, ExpectedResult = "3.04184")]
        [TestCase(20, ExpectedResult = "3.09162")]
        [TestCase(100, ExpectedResult = "3.13159")]
        [TestCase(150000, ExpectedResult = "3.14159")]
        public string TestCalculatePi(int iterations)
        {
            var app = new Action(CalculatePi.Main);
            var r = app.Run(iterations);
            decimal expected = r.FetchValue<decimal>();
            return $"{expected:F5}";
        }
    }
}
