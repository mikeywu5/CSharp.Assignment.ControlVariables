using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharp.Tests.Library;

namespace Basic.BooleanIndicator.Tests
{
    class ConcatenateWordsTests
    {
        public void TestConcatenateWords()
        {
            var app = new Action(ConcatenateWords.Main);
            string expected, actual;
            
            actual = app.Run().Trim();
            expected = "";
            Assert.AreEqual(expected, actual);

            actual = app.Run("Hello").Trim();
            expected = "Hello";
            Assert.AreEqual(expected, actual);

            actual = app.Run("Hello", "World").Trim();
            expected = "Hello World";
            Assert.AreEqual(expected, actual);

            actual = app.Run("The", "Quick", "Brown", "Fox", "Jumps", "over", "a", "Lazy", "Dog.").Trim();
            expected = "The Quick Brown Fox Jumps over a Lazy Dog.";
            Assert.AreEqual(expected, actual);
        }
    }
}
