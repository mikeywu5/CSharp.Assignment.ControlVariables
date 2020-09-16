using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharp.Tests.Library;

namespace Basic.Product.Tests
{
    public class CompoundInterstTests
    {
        [Test]
        public void TestCompoundInterest()
        {
            var app = new Action(CompoundInterest.Main);
            decimal principal = 123456.78m;
            int year = 20;
            decimal rate = 0.05m;
            const decimal expected = 327567.5910585195447040715779786m;
            string r = app.Run(principal, year, rate);
            decimal actual = r.FetchValue<decimal>();
            Assert.AreEqual($"{expected:F2}", $"{actual:F2}");
        }
    }
}
