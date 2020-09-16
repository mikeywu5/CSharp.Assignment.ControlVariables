using System;
using NUnit.Framework;
using System.Text.RegularExpressions;
using CSharp.Tests.Library;
using System.Collections.Generic;
using System.Linq;

namespace Problems.Tests
{
    public class LongSequenceInOrdersTests
    {
        [TestCase(ExpectedResult = new int[0])]
        [TestCase(0, ExpectedResult = new[] {
            1, 0 })]
        [TestCase(-100, -200, -300, ExpectedResult = new[] {
            1, -100 })]
        [TestCase(1, 2, 3, 4, 5, ExpectedResult = new[] {
            5, 1, 2, 3, 4, 5 })]
        [TestCase(1, 5, 7, 2, 3, 8, 10, ExpectedResult = new[] {
            4, 2, 3, 8, 10 })]
        [TestCase(1, 5, 7, 9, 100, 2, 3, 8, 10, ExpectedResult = new[] {
            5, 1, 5, 7, 9, 100 })]
        [TestCase(8, -9, -7, 0, 6, 8, 7, 12, 17, 19, 25, 34, 35, 37, 43, -30, -26, -21, -17, -14, -10, 0, 6, 10, 14, 19, 20, 25, 5, 6, 9, 10, 12, 19, 23, 32, -17, -8, -2, 1, 6, 13, 16, 25, 33, ExpectedResult = new[] {
            13, -30, -26, -21, -17, -14, -10, 0, 6, 10, 14, 19, 20, 25 })]
        [TestCase(-91, -44, -37, -26, -18, -11, -2, -1, 4, 5, -2, 2, 7, 14, 22, 6, 13, 19, 24, 26, 28, -14, -11, -9, -2, 0, 5, 8, -2, 1, 2, 3, 6, 10, 15, 21, 16, 21, 24, 33, 40, 43, 50, 54, 62, ExpectedResult = new[] {
            10, -91, -44, -37, -26, -18, -11, -2, -1, 4, 5 })]
        [TestCase(-2, 2, 7, 14, 22, 6, 13, 19, 24, 26, 28, -14, -11, -9, -2, 0, 5, 8, -2, 1, 2, 3, 6, 10, 15, 21, 16, 21, 24, 33, 40, 43, 50, 54, 62, -91, -44, -37, -26, -18, -11, -2, -1, 4, 5, ExpectedResult = new[] {
            10, -91, -44, -37, -26, -18, -11, -2, -1, 4, 5 })]
        public int[] TestLongSequenceInOrders(params int[] input)
        {

            Action app = new Action(LongSequenceInOrders.Main);
            var r = app.Run(input);
            var actual = r.FetchValues<int>();
            return actual.ToArray();
        }
    }
}
