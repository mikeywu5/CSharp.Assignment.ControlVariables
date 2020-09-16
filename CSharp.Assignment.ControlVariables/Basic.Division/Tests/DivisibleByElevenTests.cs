using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using CSharp.Tests.Library;
namespace Basic.Division.Tests
{
    public class DivisibleByElevenTests
    {
        [Test]
        public void TestDivisibleByEleven()
        {
            var app = new Action(DivisibleByEleven.Main);
            string r = app.Run(11);
            bool actual = r.FetchValue<bool>();
            Assert.IsTrue(actual);

            r = app.Run(-15763);
            actual = r.FetchValue<bool>();
            Assert.IsTrue(actual);

            r = app.Run(15761);
            actual = r.FetchValue<bool>();
            Assert.IsFalse(actual);

            r = app.Run(9090909090909090907L);
            actual = r.FetchValue<bool>();
            Assert.IsTrue(actual);

            r = app.Run(-7090909090909090909L);
            actual = r.FetchValue<bool>();
            Assert.IsTrue(actual);
        }
    }
}
