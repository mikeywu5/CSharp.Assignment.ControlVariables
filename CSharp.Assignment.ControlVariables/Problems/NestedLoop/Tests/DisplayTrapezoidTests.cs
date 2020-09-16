using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharp.Tests.Library;

namespace Problems.NestedLoop.Tests
{
    class DisplayTrapezoidTests
    {
        [Test]
        public void TestDisplayTrapezoid()
        {
            Action app = new Action(DisplayTrapezoid.Main);
            string actual;

            actual = app.Run(0, 0);
            actual.Assert();

            actual = app.Run(1, "a");
            actual.Assert(
            "aaa");

            actual = app.Run(2, "B");
            actual.Assert(
            " BBBB ",
            "BBBBBB");

            actual = app.Run(3, "c");
            actual.Assert(
            "  ccccc  ",
            " ccccccc ",
            "ccccccccc");

            actual = app.Run(4, "D");
            actual.Assert(
            "   DDDDDD   ",
            "  DDDDDDDD  ",
            " DDDDDDDDDD ",
            "DDDDDDDDDDDD");

            actual = app.Run(5, "?");
            actual.Assert(
            "    ???????    ",
            "   ?????????   ",
            "  ???????????  ",
            " ????????????? ",
            "???????????????");

            actual = app.Run(6, "X");
            actual.Assert(
            "     XXXXXXXX     ",
            "    XXXXXXXXXX    ",
            "   XXXXXXXXXXXX   ",
            "  XXXXXXXXXXXXXX  ",
            " XXXXXXXXXXXXXXXX ",
            "XXXXXXXXXXXXXXXXXX");

            actual = app.Run(7, "!");
            actual.Assert(
            "      !!!!!!!!!      ",
            "     !!!!!!!!!!!     ",
            "    !!!!!!!!!!!!!    ",
            "   !!!!!!!!!!!!!!!   ",
            "  !!!!!!!!!!!!!!!!!  ",
            " !!!!!!!!!!!!!!!!!!! ",
            "!!!!!!!!!!!!!!!!!!!!!");

            actual = app.Run(8, "@");
            actual.Assert(
            "       @@@@@@@@@@       ",
            "      @@@@@@@@@@@@      ",
            "     @@@@@@@@@@@@@@     ",
            "    @@@@@@@@@@@@@@@@    ",
            "   @@@@@@@@@@@@@@@@@@   ",
            "  @@@@@@@@@@@@@@@@@@@@  ",
            " @@@@@@@@@@@@@@@@@@@@@@ ",
            "@@@@@@@@@@@@@@@@@@@@@@@@");

            actual = app.Run(9, "#");
            actual.Assert(
            "        ###########        ",
            "       #############       ",
            "      ###############      ",
            "     #################     ",
            "    ###################    ",
            "   #####################   ",
            "  #######################  ",
            " ######################### ",
            "###########################");

            actual = app.Run(10, "$");
            actual.Assert(
            "         $$$$$$$$$$$$         ",
            "        $$$$$$$$$$$$$$        ",
            "       $$$$$$$$$$$$$$$$       ",
            "      $$$$$$$$$$$$$$$$$$      ",
            "     $$$$$$$$$$$$$$$$$$$$     ",
            "    $$$$$$$$$$$$$$$$$$$$$$    ",
            "   $$$$$$$$$$$$$$$$$$$$$$$$   ",
            "  $$$$$$$$$$$$$$$$$$$$$$$$$$  ",
            " $$$$$$$$$$$$$$$$$$$$$$$$$$$$ ",
            "$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        }
    }
}