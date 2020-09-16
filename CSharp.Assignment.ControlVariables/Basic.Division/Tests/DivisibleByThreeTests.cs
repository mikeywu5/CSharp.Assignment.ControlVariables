using System;
using System.Collections.Generic;
using System.Text;
using CSharp.Tests.Library;
using NUnit.Framework;

namespace Basic.Division.Tests
{
    public class DivisibleByThreeTests
    {
        [Test]
        public void TestDivisibleByThree()
        {
            var app = new Action(DivisibleByThree.Main);

            string r = app.Run(1);
            bool actual = r.FetchValue<bool>();
            Assert.IsFalse(actual);

            r = app.Run(123);
            actual = r.FetchValue<bool>();
            Assert.IsTrue(actual);

            r = app.Run(-23);
            actual = r.FetchValue<bool>();
            Assert.IsFalse(actual);

            r = app.Run(123456789);
            actual = r.FetchValue<bool>();
            Assert.IsTrue(actual);

            r = app.Run(9876543211);
            actual = r.FetchValue<bool>();
            Assert.IsFalse(actual);

            r = app.Run(-9827654321);
            actual = r.FetchValue<bool>();
            Assert.IsFalse(actual);

            r = app.Run(999999999999999999L);
            actual = r.FetchValue<bool>();
            Assert.IsTrue(actual);

            r = app.Run(-99999999999999999L);
            actual = r.FetchValue<bool>();
            Assert.IsTrue(actual);
        }
    }
}
