using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharp.Tests.Library;

namespace Problems.Tests
{
    class CountSmallSquareSetTests
    {
        [Test]
        public void TestCountSmallestSquareSet()
        {
            Action app = new Action(CountSmallSquareSet.Main);
            string actual;

            actual = app.Run();
            actual.Assert(0);

            actual = app.Run(6);
            actual.Assert(0);

            actual = app.Run(6, 8);
            actual.Assert(0);

            actual = app.Run(6, 8, 40);
            actual.Assert(1);

            actual = app.Run(6, 8, 40, 4);
            actual.Assert(1);

            actual = app.Run(6, 8, 40, 4, 2);
            actual.Assert(1);

            actual = app.Run(6, 8, 40, 4, 2, 3);
            actual.Assert(1);

            actual = app.Run(6, 8, 40, 4, 2, 3, 8);
            actual.Assert(2);

            actual = app.Run(6, 8, 40, 4, 2, 3, 8, 63);
            actual.Assert(2);

            actual = app.Run(6, 8, 40, 4, 2, 3, 8, 63, 20);
            actual.Assert(2);

            actual = app.Run(6, 8, 40, 4, 2, 3, 8, 63, 20, 3);
            actual.Assert(2);

            actual = app.Run(6, 8, 40, 4, 2, 3, 8, 63, 20, 3, 4);
            actual.Assert(2);

            actual = app.Run(6, 8, 40, 4, 2, 3, 8, 63, 20, 3, 4, 6);
            actual.Assert(2);

            actual = app.Run(6, 8, 40, 4, 2, 3, 8, 63, 20, 3, 4, 6, 3);
            actual.Assert(2);

            actual = app.Run(6, 8, 40, 4, 2, 3, 8, 63, 20, 3, 4, 6, 3, 10);
            actual.Assert(3);

            actual = app.Run(6, 8, 40, 4, 2, 3, 8, 63, 20, 3, 4, 6, 3, 10, 1);
            actual.Assert(3);

            actual = app.Run(6, 8, 40, 4, 2, 3, 8, 63, 20, 3, 4, 6, 3, 10, 1, 1);
            actual.Assert(4);

            actual = app.Run(6, 8, 40, 4, 2, 3, 8, 63, 20, 3, 4, 6, 3, 10, 1, 1, 1);
            actual.Assert(4);

            actual = app.Run(6, 8, 40, 4, 2, 3, 8, 63, 20, 3, 4, 6, 3, 10, 1, 1, 1, 3);
            actual.Assert(5);

            actual = app.Run(6, 8, 40, 4, 2, 3, 8, 63, 20, 3, 4, 6, 3, 10, 1, 1, 1, 3, 5);
            actual.Assert(5);

            actual = app.Run(6, 8, 40, 4, 2, 3, 8, 63, 20, 3, 4, 6, 3, 10, 1, 1, 1, 3, 5, 0);
            actual.Assert(5);

            actual = app.Run(6, 8, 40, 4, 2, 3, 8, 63, 20, 3, 4, 6, 3, 10, 1, 1, 1, 3, 5, 0, 2);
            actual.Assert(5);
        }
    }
}
