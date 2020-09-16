using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharp.Tests.Library;
using System.Linq;

namespace Basic.BooleanIndicator.Tests
{
    class EmptyLineTests
    {
        [Test]
        public void TestEmptyLine()
        {
            var app = new Action(EmptyLine.Main);
            bool actual;
            string r;

            r = app.Run();
            actual = r.FetchText("blank").Any();
            Assert.IsFalse(actual);

            r = app.Run("Hello");
            actual = r.FetchText("blank").Any();
            Assert.IsFalse(actual);

            r = app.Run("Hello", "World");
            actual = r.FetchText("blank").Any();
            Assert.IsFalse(actual);

            r = app.Run("Hello", "", "World");
            actual = r.FetchText("blank").Any();
            Assert.IsTrue(actual);

            r = app.Run("", "Hello", "World");
            actual = r.FetchText("blank").Any();
            Assert.IsTrue(actual);

            r = app.Run("", "", "", "World");
            actual = r.FetchText("blank").Any();
            Assert.IsTrue(actual);

            r = app.Run("", "Hello", "", "World");
            actual = r.FetchText("blank").Any();
            Assert.IsTrue(actual);

        }
    }
}
