using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using CSharp.Tests.Library;

namespace Basic.Counting.Tests
{
    class EmptyLinesTests
    {
        [Test]
        public void TestEmptyLines()
        {
            var app = new Action(EmptyLines.Main);
            string r = app.Run("one", "two", "three", "four");
            int actual = r.FetchValue<int>();
            int expected = 0;
            Assert.AreEqual(expected, actual);

            r = app.Run("one", "", "two", "three", "", "four", "five", "six", "", "", "seven", "eight");
            actual = r.FetchValue<int>();
            expected = 4;
            Assert.AreEqual(expected, actual);
        }
    }
}
