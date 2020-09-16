using System;
using System.Collections.Generic;
using System.Text;
using CSharp.Tests.Library;
using NUnit.Framework;

namespace Basic.Division.Tests
{
    public class OneSumsTests
    {
        [Test]
        public void TestOneSums()
        {
            var app = new Action(OneSums.Main);
            string r = app.Run(7);
            int actual = r.FetchValue<short>();
            short expected = 3;
            Assert.AreEqual(expected, actual);

            r = app.Run(long.MaxValue);
            actual = r.FetchValue<short>();
            expected = 63;
            Assert.AreEqual(expected, actual);

            r = app.Run(1041174066);
            actual = r.FetchValue<short>();
            expected = 15;
            Assert.AreEqual(expected, actual);
        }
    }
}
