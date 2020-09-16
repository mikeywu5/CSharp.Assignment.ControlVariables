using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharp.Tests.Library;

namespace Basic.Product.Tests
{
    class FactorialTests
    {
        [Test]
        public static void TestFactorial()
        {
            var app = new Action(Factorial.Main);
            var r = app.Run(0);
            long actual = r.FetchValue<long>();
            long expected = 1;
            Assert.AreEqual(expected, actual);

            r = app.Run(1);
            actual = r.FetchValue<long>();
            expected = 1;
            Assert.AreEqual(expected, actual);

            r = app.Run(10);
            actual = r.FetchValue<long>();
            expected = 3628800;
            Assert.AreEqual(expected, actual);
        }
    }
}
