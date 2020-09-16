using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using CSharp.Tests.Library;

namespace Basic.Counting.Tests
{
    class EnteringLinesTests
    {
        [Test]
        public void TestEnteringLines()
        {
            var app = new Action(EnteringLines.Main);
            string r = app.Run(4, "one", "two", "three", "four");
            // there are no tests in this one.
        }
    }
}
