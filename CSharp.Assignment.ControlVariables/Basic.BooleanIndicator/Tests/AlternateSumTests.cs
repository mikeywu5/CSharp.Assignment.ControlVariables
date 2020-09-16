using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharp.Tests.Library;

namespace Basic.BooleanIndicator.Tests
{
    class AlternateSumTests
    { 
        [Test]
        public void TestAlternateSum()
        {
            var app = new Action(AlternateSum.Main);
            string r;
            int expected, actual;
            r = app.Run();
            expected = r.FetchValue<int>();
            actual = 0;
            Assert.AreEqual(expected, actual);

            r = app.Run(10);
            expected = r.FetchValue<int>();
            actual = 10;
            Assert.AreEqual(expected, actual);

            r = app.Run(10, 20);
            expected = r.FetchValue<int>();
            actual = -10;
            Assert.AreEqual(expected, actual);

            r = app.Run(10, 20, 30);
            expected = r.FetchValue<int>();
            actual = 20;
            Assert.AreEqual(expected, actual);

            r = app.Run(10, 30, 25, 7);
            expected = r.FetchValue<int>();
            actual = -2;
            Assert.AreEqual(expected, actual);

            r = app.Run(10, 30, 25, 7, 9, 5, 10);
            expected = r.FetchValue<int>();
            actual = 12;
            Assert.AreEqual(expected, actual);
        }
    }
}
