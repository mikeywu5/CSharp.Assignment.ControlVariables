using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharp.Tests.Library;
namespace Problems.Tests
{
    class PythagoreanTriplesContinuousTests
    {
        [Test]
        public void TestPythagoreanTriplesContinuous()
        {
            var app = new Action(PythagoreanTriplesContinuous.Main);
            var r = app.Run(3, 4, 5, 12, 13, 5, 4, 3, -5, 4, 7, -17, 15, 8, 6, 10, 10, 10);
            var actuals = r.FetchValues<int>();

            int actualTriples = actuals[actuals.Count - 3];
            int actualHypotenuse = actuals[actuals.Count - 2];
            int actualSum = actuals[actuals.Count - 1];

            int expectedTriples = 8;
            int expectedHypotenuse = 17;
            int expectedSum = 27;

            Assert.AreEqual(expectedTriples, actualTriples, "The number of Pythagorean triples is wrong.");
            Assert.AreEqual(expectedHypotenuse, actualHypotenuse, "The largest hypotenuse is wrong.");
            Assert.AreEqual(expectedSum, actualSum, "The sum of non-pythagorean triples is wrong.");
        }
    }
}
