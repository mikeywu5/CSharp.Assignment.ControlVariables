using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharp.Tests.Library;

namespace Basic.Product.Tests
{
    class PowerTests
    {
        [Test]
        public void TestPower()
        {
            var app = new Action(Power.Main);
            var r = app.Run(0.5, 0);
            decimal actual = r.FetchValue<decimal>();
            decimal expected = 1;
            Assert.AreEqual(expected, actual);

            r = app.Run(-0.5, 1);
            actual = r.FetchValue<decimal>();
            expected = -0.5m;
            Assert.AreEqual(expected, actual);

            r = app.Run(-0.9, 101);
            actual = r.FetchValue<decimal>();
            expected = -2.390525899882872924049031898322e-5m;
            Assert.AreEqual($"{expected:F6}", $"{actual:F6}");
        }
    }
}
