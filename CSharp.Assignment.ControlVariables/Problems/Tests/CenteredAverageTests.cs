using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharp.Tests.Library;
namespace Problems.Tests
{
    class CenteredAverageTests
    {
        [Test]
        public void TestCenteredAverage()
        {
            Action app = new Action(CenteredAverage.Main);
            int expected, actual;

            var r = app.Run(1, 2, 3, 4, 100);
            actual = r.FetchValue<int>();
            expected = 3;

            r = app.Run(1, 1, 5, 5, 10, 8, 7);
            actual = r.FetchValue<int>();
            expected = 5;
            Assert.AreEqual(expected, actual);

            r = app.Run(-10, -4, -2, -4, -2, 0);
            actual = r.FetchValue<int>();
            expected = -3;
            Assert.AreEqual(expected, actual);

            r = app.Run(5, 3, 4, 6, 2);
            actual = r.FetchValue<int>();
            expected = 4;
            Assert.AreEqual(expected, actual);

            r = app.Run(5, 3, 4, 0, 100);
            actual = r.FetchValue<int>();
            expected = 4;
            Assert.AreEqual(expected, actual);

            r = app.Run(100, 0, 5, 3, 4);
            actual = r.FetchValue<int>();
            expected = 4;
            Assert.AreEqual(expected, actual);

            r = app.Run(4, 0, 100);
            actual = r.FetchValue<int>();
            expected = 4;
            Assert.AreEqual(expected, actual);

            r = app.Run(0, 2, 3, 4, 100);
            actual = r.FetchValue<int>();
            expected = 3;
            Assert.AreEqual(expected, actual);

            r = app.Run(1, 1, 100);
            actual = r.FetchValue<int>();
            expected = 1;
            Assert.AreEqual(expected, actual);

            r = app.Run(7, 7, 7);
            actual = r.FetchValue<int>();
            expected = 7;
            Assert.AreEqual(expected, actual);

            r = app.Run(1, 7, 8);
            actual = r.FetchValue<int>();
            expected = 7;
            Assert.AreEqual(expected, actual);

            r = app.Run(1, 1, 99, 99);
            actual = r.FetchValue<int>();
            expected = 50;
            Assert.AreEqual(expected, actual);

            r = app.Run(1000, 0, 1, 99);
            actual = r.FetchValue<int>();
            expected = 50;
            Assert.AreEqual(expected, actual);

            r = app.Run(4, 4, 4, 4, 5);
            actual = r.FetchValue<int>();
            expected = 4;
            Assert.AreEqual(expected, actual);

            r = app.Run(4, 4, 4, 1, 5);
            actual = r.FetchValue<int>();
            expected = 4;
            Assert.AreEqual(expected, actual);

            r = app.Run(6, 4, 8, 12, 3);
            actual = r.FetchValue<int>();
            expected = 6;
            Assert.AreEqual(expected, actual);
        }
    }
}