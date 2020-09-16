using System;
using System.Collections.Generic;
using System.Text;
using CSharp.Tests.Library;
using NUnit.Framework;

namespace Problems.Tests
{
    class AveragesTests
    {
        [Test]
        public void TestAverages()
        {
            Action app = new Action(Averages.Main);
            string r;
            int expected, actual;
            r = app.Run(); // no inputs
            expected = 0;
            actual = r.FetchValue<int>();
            Assert.AreEqual(expected, actual);

            r = app.Run(10);
            expected = 10;
            actual = r.FetchValue<int>();
            Assert.AreEqual(expected, actual);

            r = app.Run(2, 1, 7, 4, 3);
            expected = 3;
            actual = r.FetchValue<int>();
            Assert.AreEqual(expected, actual);

            r = app.Run(-10, 7, 0, 8, 10, 3, -3, -7);
            expected = 1;
            actual = r.FetchValue<int>();
            Assert.AreEqual(expected, actual);
        }
    }
}