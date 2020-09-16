using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharp.Tests.Library;

namespace Problems.Tests
{
    class ConsecutiveAveragesTests
    {

        public void TestConsecutiveAverages()
        {
            Action app = new Action(ConsecutiveAverages.Main);
            string actual;

            actual = app.Run(); // none
            actual.Assert(); // none indeed
            actual = app.Run(10);
            actual.Assert();

            actual = app.Run(1);
            actual.Assert();

            actual = app.Run(1, 2);
            actual.Assert("1.50");

            actual = app.Run(1, 2, 3);
            actual.Assert("1.50", "2.00");

            actual = app.Run(1, 2, 3, 4);
            actual.Assert("1.50", "2.00", "2.50");

            actual = app.Run(1, 2, 3, 4, 1);
            actual.Assert("1.50", "2.00", "2.50");

            actual = app.Run(1, 2, 3, 4, 1, 2);
            actual.Assert("1.50", "2.00", "2.50", "2.40");

            actual = app.Run(1, 2, 3, 4, 1, 2, 3);
            actual.Assert("1.50", "2.00", "2.50", "2.40", "2.50");

            actual = app.Run(1, 2, 3, 4, 1, 2, 3, 4);
            actual.Assert("1.50", "2.00", "2.50", "2.40", "2.50", "2.50");

            actual = app.Run(1, 2, 3, 4, 1, 2, 3, 4, 3);
            actual.Assert("1.50", "2.00", "2.50", "2.40", "2.50", "2.50");

            actual = app.Run(1, 2, 3, 4, 1, 2, 3, 4, 3, 4);
            actual.Assert("1.50", "2.00", "2.50", "2.40", "2.50", "2.50", "2.57");

            actual = app.Run(1, 2, 3, 4, 1, 2, 3, 4, 3, 4, 5);
            actual.Assert("1.50", "2.00", "2.50", "2.40", "2.50", "2.50", "2.57", "3.10");

            actual = app.Run(1, 2, 3, 4, 1, 2, 3, 4, 3, 4, 5, 6);
            actual.Assert("1.50", "2.00", "2.50", "2.40", "2.50", "2.50", "2.57", "3.10", "3.36");

            actual = app.Run(1, 2, 3, 4, 1, 2, 3, 4, 3, 4, 5, 6, 10);
            actual.Assert("1.50", "2.00", "2.50", "2.40", "2.50", "2.50", "2.57", "3.10", "3.36");

            actual = app.Run(1, 2, 3, 4, 1, 2, 3, 4, 3, 4, 5, 6, 10, 10);
            actual.Assert("1.50", "2.00", "2.50", "2.40", "2.50", "2.50", "2.57", "3.10", "3.36");

            actual = app.Run(1, 2, 3, 4, 1, 2, 3, 4, 3, 4, 5, 6, 10, 10, 10);
            actual.Assert("1.50", "2.00", "2.50", "2.40", "2.50", "2.50", "2.57", "3.10", "3.36");

            actual = app.Run(1, 2, 3, 4, 1, 2, 3, 4, 3, 4, 5, 6, 10, 10, 10, 5);
            actual.Assert("1.50", "2.00", "2.50", "2.40", "2.50", "2.50", "2.57", "3.10", "3.36");

            actual = app.Run(1, 2, 3, 4, 1, 2, 3, 4, 3, 4, 5, 6, 10, 10, 10, 5, 6);
            actual.Assert("1.50", "2.00", "2.50", "2.40", "2.50", "2.50", "2.57", "3.10", "3.36", "3.50");

            actual = app.Run(1, 2, 3, 4, 1, 2, 3, 4, 3, 4, 5, 6, 10, 10, 10, 5, 6, 7);
            actual.Assert("1.50", "2.00", "2.50", "2.40", "2.50", "2.50", "2.57", "3.10", "3.36", "3.50", "3.93");
        }
    }
}