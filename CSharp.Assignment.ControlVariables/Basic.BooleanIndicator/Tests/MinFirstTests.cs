﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharp.Tests.Library;

namespace Basic.BooleanIndicator.Tests
{
    class MinFirstTests
    {
        const string Case1 = "A. 1 thru 10";
        const string Case2 = "B. Uniques";
        const string Case3 = "C. Sames";
        const string Case4 = "D. Repeats";
        [TestCase(Case1, Description = Case1)]
        [TestCase(Case2, Description = Case2)]
        [TestCase(Case3, Description = Case3)]
        [TestCase(Case4, Description = Case4)]
        [Category("Loop")]
        public void TestSmallest(string testCase)
        {
            Action app = new Action(MinFirst.Main);
            string result;
            decimal expected, actual;
            switch (testCase)
            {
                case Case1:
                    result = app.Run(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
                    actual = result.FetchValue<decimal>();
                    expected = 1;
                    Assert.AreEqual(expected, actual);
                    result = app.Run(-1, -2, -3, -4, -5, -6, -7, -8, -9, -10);
                    actual = result.FetchValue<decimal>();
                    expected = -10;
                    Assert.AreEqual(expected, actual);
                    break;

                case Case2:
                    result = app.Run(86413, 31728, 83272, 72137, 90522, 32072, 77765, 20890, 80355, 36987);
                    actual = result.FetchValue<decimal>();
                    expected = 20890m;
                    Assert.AreEqual(expected, actual);

                    result = app.Run(-86413, -31728, -83272, -72137, -90522, -32072, -77765, -20890, -80355, -36987);
                    actual = result.FetchValue<decimal>();
                    expected = -90522m;
                    Assert.AreEqual(expected, actual);
                    break;

                case Case3:
                    result = app.Run(10, 10, 10, 10, 10, 10, 10, 10, 10, 10);
                    actual = result.FetchValue<decimal>();
                    expected = 10;
                    Assert.AreEqual(expected, actual);

                    result = app.Run(-10, -10, -10, -10, -10, -10, -10, -10, -10, -10);
                    actual = result.FetchValue<decimal>();
                    expected = -10;
                    Assert.AreEqual(expected, actual);

                    break;

                case Case4:
                    result = app.Run(19, 87, 41, 45, 96, 41, 21, 45, 80, 87);
                    actual = result.FetchValue<decimal>();
                    expected = 19m;
                    Assert.AreEqual(expected, actual);
                    
                    result = app.Run(19, 87, 41, 45, 96, 41, 21, 45, 80, 96);
                    actual = result.FetchValue<decimal>();
                    expected = 19m;
                    Assert.AreEqual(expected, actual);

                    result = app.Run(-19, -87, -41, -45, -96, -41, -21, -45, -80, -21);
                    actual = result.FetchValue<decimal>();
                    expected = -96;
                    Assert.AreEqual(expected, actual);

                    result = app.Run(-19, -87, -41, -45, -96, -41, -21, -45, -80, -19);
                    actual = result.FetchValue<decimal>();
                    expected = -96;
                    Assert.AreEqual(expected, actual);

                    result = app.Run(-19, -87, -41, -45, 96, -41, -21, -45, -80, -19);
                    actual = result.FetchValue<decimal>();
                    expected = -87;
                    Assert.AreEqual(expected, actual);

                    result = app.Run(-19, -87, -41, -45, -96, -41, -21, -45, -80, -96);
                    actual = result.FetchValue<decimal>();
                    expected = -96;
                    Assert.AreEqual(expected, actual);
                    break;
            }
        }
    }
}
