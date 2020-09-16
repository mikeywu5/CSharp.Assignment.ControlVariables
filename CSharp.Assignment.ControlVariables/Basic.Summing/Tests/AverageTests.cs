using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharp.Tests.Library;

namespace Basic.Summing.Tests
{
    class AverageTests
    {
        [Test]
        public void TestAverage()
        {
            var app = new Action(Average.Main);
            var r = app.Run(0);
            decimal actual = r.FetchValue<decimal>();
            decimal expected = 0;
            Assert.AreEqual($"{expected:N}", $"{actual:N}");
            
            r = app.Run(4, 0, 1, 2, 3, 4, 5, 6, 7, 9);
            actual = r.FetchValue<decimal>();
            expected = 1.5m;
            Assert.AreEqual($"{expected:N}", $"{actual:N}");

            r = app.Run(5, 99, -1, 0, 1, 101, 50, -123, 100, 177);
            actual = r.FetchValue<decimal>();
            expected = 50;
            Assert.AreEqual($"{expected:N}", $"{actual:N}");
        }
    }
}
