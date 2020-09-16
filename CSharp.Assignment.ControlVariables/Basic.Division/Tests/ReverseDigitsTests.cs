using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharp.Tests.Library;

namespace Basic.Division.Tests
{
    class ReverseDigitsTests
    {
        [Test]
        public void TestReverseDigits()
        {
            var app = new Action(ReverseDigits.Main);
            string r = app.Run(123456789);
            int actual = r.FetchValue<int>();
            int expected = 987654321;
            Assert.AreEqual(expected, actual);
        }
    }
}
