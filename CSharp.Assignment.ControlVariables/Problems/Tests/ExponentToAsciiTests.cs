using System;
using System.Collections.Generic;
using System.Text;
using CSharp.Tests.Library;
using NUnit.Framework;

namespace Problems.Tests
{
    class ExponentToAsciiTests
    {
        [Test]
        public void TestExponentToAscii()
        {
            Action app = new Action(ExponentToAscii.Main);
            string actual;
            actual = app.Run(); // empty
            actual.Assert(); // empty

            actual = app.Run("2^9");
            actual.Assert(
            " 9",
            "2 ");

            actual = app.Run("2^1234567890");
            actual.Assert(
            " 1234567890",
            "2          ");

            actual = app.Run("91^(1234567890123)");
            actual.Assert(
            "  1234567890123",
            "91             ");

            actual = app.Run("a^x");
            actual.Assert(
            " x",
            "a ");

            actual = app.Run("a^xy");
            actual.Assert(
            " xy",
            "a  ");

            actual = app.Run("a^123^y");
            actual.Assert(
            " 123y",
            "a    ");

            actual = app.Run("a + 6^x");
            actual.Assert(
            "     x",
            "a + 6 ");

            actual = app.Run("(a+b)^(x+y)");
            actual.Assert(
            "     x+y",
            "(a+b)   ");

            actual = app.Run("(a+b)^(x+y)^z");
            actual.Assert(
            "     x+yz",
            "(a+b)    ");

            actual = app.Run("(a+b)^(x+y)+cb^(z+x)");
            actual.Assert(
            "     x+y   z+x",
            "(a+b)   +cb   ");

            actual = app.Run("(a+b)^(x+y)+cb^(z*x^z)");
            actual.Assert(
            "     x+y   z*x^z",
            "(a+b)   +cb     ");

            actual = app.Run("abc^d+ef^g + hijk^l - M^(NO^P) (Ag^+)");
            actual.Assert(
            "   d   g       l    NO^P    + ",
            "abc +ef  + hijk  - M     (Ag )");

            actual = app.Run("x^(b+c)-(4^a2c)def+5^(n^6+1)");
            actual.Assert(
            " b+c   a2c      n^6+1",
            "x   -(4   )def+5     ");

        }
    }
}