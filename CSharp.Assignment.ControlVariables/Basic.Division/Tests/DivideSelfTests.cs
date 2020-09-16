using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using CSharp.Tests.Library;

namespace Basic.Division.Tests
{
    public class DivideSelfTests
    {
        [TestCase(128, ExpectedResult = true)]
        [TestCase(12, ExpectedResult = true)]
        [TestCase(120, ExpectedResult = false)]
        [TestCase(122, ExpectedResult = true)]
        [TestCase(13, ExpectedResult = false)]
        [TestCase(32, ExpectedResult = false)]
        [TestCase(22, ExpectedResult = true)]
        [TestCase(42, ExpectedResult = false)]
        [TestCase(212, ExpectedResult = true)]
        [TestCase(213, ExpectedResult = false)]
        [TestCase(162, ExpectedResult = true)]
        public bool TestDivideSelf(int number)
        {
            Action app = new Action(DivideSelf.Main);
            
            string output = app.Run(number);
            bool actual = output.FetchValue<bool>();
            return actual;
        }
    }
}