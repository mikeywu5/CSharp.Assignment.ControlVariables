using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharp.Tests.Library;

namespace Problems.Tests
{
    class BigHeightsTests
    {
            [TestCase(15432, ExpectedResult=1)]
            [TestCase(152, ExpectedResult=2)]
            [TestCase(1967153549, ExpectedResult=5)]
            [TestCase(206351482, ExpectedResult=6)]
            [TestCase(1256630565, ExpectedResult=4)]
            [TestCase(1073351882, ExpectedResult=5)]
            [TestCase(1877605296, ExpectedResult=6)]
            [TestCase(1563500473, ExpectedResult=6)]
            [TestCase(1692784121, ExpectedResult=6)]
            [TestCase(1505054181, ExpectedResult=8)]
            [TestCase(1464869932, ExpectedResult=4)]
            [TestCase(2080535711, ExpectedResult=4)]
            [TestCase(886512162, ExpectedResult=3)]
            [TestCase(1959836061, ExpectedResult=8)]
            [TestCase(1506938641, ExpectedResult=7)]
            [TestCase(850775684, ExpectedResult=4)]
            [TestCase(581252988, ExpectedResult=5)]
            [TestCase(382219315, ExpectedResult=5)]
            [TestCase(810178288, ExpectedResult=4)]
            [TestCase(715434273, ExpectedResult=4)]
            [TestCase(794849882, ExpectedResult=5)]
            [TestCase(437504964, ExpectedResult=5)]
            [TestCase(3614286209634039248L, ExpectedResult=13)]
            [TestCase(133561558220774981L, ExpectedResult=8)]
            [TestCase(1375677691230853430L, ExpectedResult=7)]
            [TestCase(4187663201784757528L, ExpectedResult=8)]
            [TestCase(1889222368676898181L, ExpectedResult=6)]
            [TestCase(3810053624139023733L, ExpectedResult=10)]
            [TestCase(4117798282261223760L, ExpectedResult=9)]
            [TestCase(941856663367033026L, ExpectedResult=10)]
            [TestCase(3799689463283646650L, ExpectedResult=8)]
            [TestCase(437114287338642570L, ExpectedResult=8)]
        public int TestBigHeights(long altitudes)
        {
            var app = new Action(BigHeights.Main);
            var r = app.Run(altitudes);
            int actual = r.FetchValue<int>();
            return actual;
        }
    }
}
