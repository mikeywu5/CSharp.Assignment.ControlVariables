using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharp.Tests.Library;
using System.Linq;

namespace Basic.BooleanIndicator.Tests
{
    class LineIndicatorTests
    {
        [Test]
        public void TestLineIndicator()
        {
            var app = new Action(LineIndicator.Main);
            bool actual;
            string r;

            r = app.Run();
            actual = r.FetchText("matched").Any();
            Assert.IsFalse(actual);

            r = app.Run("Hello");
            actual = r.FetchText("matched").Any();
            Assert.IsFalse(actual);

            r = app.Run("Hello", "World");
            actual = r.FetchText("blank").Any();
            Assert.IsFalse(actual);

            r = app.Run("Dog.", "The", "Quick", "Brown", "Fox", "Jumps", "Over", "The", "Lazy", "Dog.");
            actual = r.FetchText("matched").Any();
            Assert.IsTrue(actual);

            r = app.Run("The", "The", "Quick", "Brown", "Fox", "Jumps", "Over", "The", "Lazy", "Dog.");
            actual = r.FetchText("matched").Any();
            Assert.IsTrue(actual);

            r = app.Run("A", "The", "Quick", "Brown", "Fox", "Jumps", "Over", "The", "Lazy", "Dog.");
            actual = r.FetchText("matched").Any();
            Assert.IsFalse(actual);

        }
    }
}
