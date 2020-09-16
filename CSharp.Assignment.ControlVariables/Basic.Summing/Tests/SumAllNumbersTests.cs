using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharp.Tests.Library;

namespace Basic.Summing.Tests
{
    class SumAllNumbersTests
    {
        [Test]
        public void TestSumAllNumbers()
        {
            var app = new Action(SumAllNumbers.Main);
            var r = app.Run();
            decimal actual = r.FetchValue<decimal>();
            decimal expected = 0;
            Assert.AreEqual(expected, actual);

            r = app.Run(0);
            actual = r.FetchValue<decimal>();
            expected = 0;
            Assert.AreEqual(expected, actual);

            r = app.Run(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            actual = r.FetchValue<decimal>();
            expected = 55;
            Assert.AreEqual(expected, actual);

            r = app.Run(1, -2, 3, -4, 5, -6, 7, -8, 9, -10);
            expected = -5;
            Assert.AreEqual(expected, actual);
        }
    }
}
