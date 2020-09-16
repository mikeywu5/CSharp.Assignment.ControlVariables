using System;

namespace NUnit.Framework.Multiples
{
    /// <summary>
    /// The Assert class contains a collection of static methods that
    /// implement the most common assertions used in NUnit.
    /// </summary>
    /// <summary>
    /// The Assert class contains a collection of static methods that
    /// implement the most common assertions used in NUnit.
    /// </summary>
    //[System.Diagnostics.DebuggerNonUserCode]
    public abstract partial class Assert
    {
        /// <summary>
        /// Verifies that the first int is greater than the second
        /// int. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Greater(int arg1, int arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Greater(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first int is greater than the second
        /// int. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void Greater(int arg1, int arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Greater(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>

        public static void Greater(uint arg1, uint arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Greater(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>

        public static void Greater(uint arg1, uint arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Greater(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Greater(long arg1, long arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Greater(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void Greater(long arg1, long arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Greater(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>

        public static void Greater(ulong arg1, ulong arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Greater(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>

        public static void Greater(ulong arg1, ulong arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Greater(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Greater(decimal arg1, decimal arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Greater(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void Greater(decimal arg1, decimal arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Greater(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Greater(double arg1, double arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Greater(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void Greater(double arg1, double arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Greater(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Greater(float arg1, float arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Greater(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void Greater(float arg1, float arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Greater(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Greater(System.IComparable arg1, System.IComparable arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Greater(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void Greater(System.IComparable arg1, System.IComparable arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Greater(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Less(int arg1, int arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Less(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void Less(int arg1, int arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Less(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>

        public static void Less(uint arg1, uint arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Less(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>

        public static void Less(uint arg1, uint arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Less(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Less(long arg1, long arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Less(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void Less(long arg1, long arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Less(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>

        public static void Less(ulong arg1, ulong arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Less(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>

        public static void Less(ulong arg1, ulong arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Less(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Less(decimal arg1, decimal arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Less(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void Less(decimal arg1, decimal arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Less(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Less(double arg1, double arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Less(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void Less(double arg1, double arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Less(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Less(float arg1, float arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Less(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void Less(float arg1, float arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Less(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Less(System.IComparable arg1, System.IComparable arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Less(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void Less(System.IComparable arg1, System.IComparable arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Less(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void GreaterOrEqual(int arg1, int arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.GreaterOrEqual(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void GreaterOrEqual(int arg1, int arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.GreaterOrEqual(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>

        public static void GreaterOrEqual(uint arg1, uint arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.GreaterOrEqual(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>

        public static void GreaterOrEqual(uint arg1, uint arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.GreaterOrEqual(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void GreaterOrEqual(long arg1, long arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.GreaterOrEqual(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void GreaterOrEqual(long arg1, long arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.GreaterOrEqual(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>

        public static void GreaterOrEqual(ulong arg1, ulong arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.GreaterOrEqual(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>

        public static void GreaterOrEqual(ulong arg1, ulong arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.GreaterOrEqual(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void GreaterOrEqual(decimal arg1, decimal arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.GreaterOrEqual(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void GreaterOrEqual(decimal arg1, decimal arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.GreaterOrEqual(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void GreaterOrEqual(double arg1, double arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.GreaterOrEqual(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void GreaterOrEqual(double arg1, double arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.GreaterOrEqual(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void GreaterOrEqual(float arg1, float arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.GreaterOrEqual(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void GreaterOrEqual(float arg1, float arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.GreaterOrEqual(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void GreaterOrEqual(System.IComparable arg1, System.IComparable arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.GreaterOrEqual(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void GreaterOrEqual(System.IComparable arg1, System.IComparable arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.GreaterOrEqual(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void LessOrEqual(int arg1, int arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.LessOrEqual(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void LessOrEqual(int arg1, int arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.LessOrEqual(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>

        public static void LessOrEqual(uint arg1, uint arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.LessOrEqual(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>

        public static void LessOrEqual(uint arg1, uint arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.LessOrEqual(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void LessOrEqual(long arg1, long arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.LessOrEqual(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void LessOrEqual(long arg1, long arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.LessOrEqual(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>

        public static void LessOrEqual(ulong arg1, ulong arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.LessOrEqual(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>

        public static void LessOrEqual(ulong arg1, ulong arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.LessOrEqual(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void LessOrEqual(decimal arg1, decimal arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.LessOrEqual(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void LessOrEqual(decimal arg1, decimal arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.LessOrEqual(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void LessOrEqual(double arg1, double arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.LessOrEqual(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void LessOrEqual(double arg1, double arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.LessOrEqual(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void LessOrEqual(float arg1, float arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.LessOrEqual(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void LessOrEqual(float arg1, float arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.LessOrEqual(arg1, arg2));
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void LessOrEqual(System.IComparable arg1, System.IComparable arg2, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.LessOrEqual(arg1, arg2, message, args));
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown. 
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void LessOrEqual(System.IComparable arg1, System.IComparable arg2)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.LessOrEqual(arg1, arg2));
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void True(bool? condition, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.True(condition, message, args));
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void True(bool condition, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.True(condition, message, args));
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        public static void True(bool? condition)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.True(condition));
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        public static void True(bool condition)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.True(condition));
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsTrue(bool? condition, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.True(condition, message, args));
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsTrue(bool condition, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsTrue(condition, message, args));
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        public static void IsTrue(bool? condition)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsTrue(condition));
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        public static void IsTrue(bool condition)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsTrue(condition));
        }

        /// <summary>
        /// Asserts that a condition is false. If the condition is true the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary> 
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void False(bool? condition, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsTrue(condition, message, args));
        }

        /// <summary>
        /// Asserts that a condition is false. If the condition is true the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary> 
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void False(bool condition, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.False(condition, message, args));
        }

        /// <summary>
        /// Asserts that a condition is false. If the condition is true the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary> 
        /// <param name="condition">The evaluated condition</param>
        public static void False(bool? condition)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.False(condition));
        }

        /// <summary>
        /// Asserts that a condition is false. If the condition is true the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary> 
        /// <param name="condition">The evaluated condition</param>
        public static void False(bool condition)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.False(condition));
        }

        /// <summary>
        /// Asserts that a condition is false. If the condition is true the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary> 
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsFalse(bool? condition, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.False(condition, message, args));
        }

        /// <summary>
        /// Asserts that a condition is false. If the condition is true the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary> 
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsFalse(bool condition, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsFalse(condition, message, args));
        }

        /// <summary>
        /// Asserts that a condition is false. If the condition is true the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary> 
        /// <param name="condition">The evaluated condition</param>
        public static void IsFalse(bool? condition)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsFalse(condition));
        }

        /// <summary>
        /// Asserts that a condition is false. If the condition is true the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary> 
        /// <param name="condition">The evaluated condition</param>
        public static void IsFalse(bool condition)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsFalse(condition));
        }

        /// <summary>
        /// Verifies that the object that is passed in is not equal to <code>null</code>
        /// If the object is <code>null</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="anObject">The object that is to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void NotNull(object anObject, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.NotNull(anObject, message, args));
        }

        /// <summary>
        /// Verifies that the object that is passed in is not equal to <code>null</code>
        /// If the object is <code>null</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="anObject">The object that is to be tested</param>
        public static void NotNull(object anObject)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.NotNull(anObject));
        }

        /// <summary>
        /// Verifies that the object that is passed in is not equal to <code>null</code>
        /// If the object is <code>null</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="anObject">The object that is to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsNotNull(object anObject, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.NotNull(anObject, message, args));
        }

        /// <summary>
        /// Verifies that the object that is passed in is not equal to <code>null</code>
        /// If the object is <code>null</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="anObject">The object that is to be tested</param>
        public static void IsNotNull(object anObject)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsNotNull(anObject));
        }

        /// <summary>
        /// Verifies that the object that is passed in is equal to <code>null</code>
        /// If the object is not <code>null</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="anObject">The object that is to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Null(object anObject, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsNotNull(anObject, message, args));
        }

        /// <summary>
        /// Verifies that the object that is passed in is equal to <code>null</code>
        /// If the object is not <code>null</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="anObject">The object that is to be tested</param>
        public static void Null(object anObject)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Null(anObject));
        }

        /// <summary>
        /// Verifies that the object that is passed in is equal to <code>null</code>
        /// If the object is not <code>null</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="anObject">The object that is to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsNull(object anObject, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Null(anObject, message, args));
        }

        /// <summary>
        /// Verifies that the object that is passed in is equal to <code>null</code>
        /// If the object is not <code>null</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="anObject">The object that is to be tested</param>
        public static void IsNull(object anObject)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsNull(anObject));
        }

        /// <summary>
        /// Verifies that the double that is passed in is an <code>NaN</code> value.
        /// If the object is not <code>NaN</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="aDouble">The value that is to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsNaN(double aDouble, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsNull(aDouble, message, args));
        }

        /// <summary>
        /// Verifies that the double that is passed in is an <code>NaN</code> value.
        /// If the object is not <code>NaN</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="aDouble">The value that is to be tested</param>
        public static void IsNaN(double aDouble)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsNaN(aDouble));
        }

        /// <summary>
        /// Verifies that the double that is passed in is an <code>NaN</code> value.
        /// If the object is not <code>NaN</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="aDouble">The value that is to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsNaN(double? aDouble, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsNaN(aDouble, message, args));
        }

        /// <summary>
        /// Verifies that the double that is passed in is an <code>NaN</code> value.
        /// If the object is not <code>NaN</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="aDouble">The value that is to be tested</param>
        public static void IsNaN(double? aDouble)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsNaN(aDouble));
        }

        /// <summary>
        /// Assert that a string is empty - that is equal to string.Empty
        /// </summary>
        /// <param name="aString">The string to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsEmpty(string aString, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsEmpty(aString, message, args));
        }

        /// <summary>
        /// Assert that a string is empty - that is equal to string.Empty
        /// </summary>
        /// <param name="aString">The string to be tested</param>
        public static void IsEmpty(string aString)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsEmpty(aString));
        }

        /// <summary>
        /// Assert that an array, list or other collection is empty
        /// </summary>
        /// <param name="collection">An array, list or other collection implementing System.Collections.ICollection</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsEmpty(System.Collections.IEnumerable collection, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsEmpty(collection, message, args));
        }

        /// <summary>
        /// Assert that an array, list or other collection is empty
        /// </summary>
        /// <param name="collection">An array, list or other collection implementing System.Collections.ICollection</param>
        public static void IsEmpty(System.Collections.IEnumerable collection)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsEmpty(collection));
        }

        /// <summary>
        /// Assert that a string is not empty - that is not equal to string.Empty
        /// </summary>
        /// <param name="aString">The string to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsNotEmpty(string aString, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsEmpty(aString, message, args));
        }

        /// <summary>
        /// Assert that a string is not empty - that is not equal to string.Empty
        /// </summary>
        /// <param name="aString">The string to be tested</param>
        public static void IsNotEmpty(string aString)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsNotEmpty(aString));
        }

        /// <summary>
        /// Assert that an array, list or other collection is not empty
        /// </summary>
        /// <param name="collection">An array, list or other collection implementing System.Collections.ICollection</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsNotEmpty(System.Collections.IEnumerable collection, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsNotEmpty(collection, message, args));
        }

        /// <summary>
        /// Assert that an array, list or other collection is not empty
        /// </summary>
        /// <param name="collection">An array, list or other collection implementing System.Collections.ICollection</param>
        public static void IsNotEmpty(System.Collections.IEnumerable collection)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsNotEmpty(collection));
        }

        /// <summary>
        /// Asserts that an int is zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        public static void Zero(int actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Zero(actual));
        }

        /// <summary>
        /// Asserts that an int is zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Zero(int actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Zero(actual, message, args));
        }

        /// <summary>
        /// Asserts that an unsigned int is zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>

        public static void Zero(uint actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Zero(actual));
        }

        /// <summary>
        /// Asserts that an unsigned int is zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>

        public static void Zero(uint actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Zero(actual, message, args));
        }

        /// <summary>
        /// Asserts that a Long is zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        public static void Zero(long actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Zero(actual));
        }

        /// <summary>
        /// Asserts that a Long is zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Zero(long actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Zero(actual, message, args));
        }

        /// <summary>
        /// Asserts that an unsigned Long is zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>

        public static void Zero(ulong actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Zero(actual));
        }

        /// <summary>
        /// Asserts that an unsigned Long is zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>

        public static void Zero(ulong actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Zero(actual, message, args));
        }

        /// <summary>
        /// Asserts that a decimal is zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        public static void Zero(decimal actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Zero(actual));
        }

        /// <summary>
        /// Asserts that a decimal is zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Zero(decimal actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Zero(actual, message, args));
        }

        /// <summary>
        /// Asserts that a double is zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        public static void Zero(double actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Zero(actual));
        }

        /// <summary>
        /// Asserts that a double is zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Zero(double actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Zero(actual, message, args));
        }

        /// <summary>
        /// Asserts that a float is zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        public static void Zero(float actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Zero(actual));
        }

        /// <summary>
        /// Asserts that a float is zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Zero(float actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Zero(actual, message, args));
        }

        /// <summary>
        /// Asserts that an int is not zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        public static void NotZero(int actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.NotZero(actual));
        }

        /// <summary>
        /// Asserts that an int is not zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void NotZero(int actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.NotZero(actual, message, args));
        }

        /// <summary>
        /// Asserts that an unsigned int is not zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>

        public static void NotZero(uint actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.NotZero(actual));
        }

        /// <summary>
        /// Asserts that an unsigned int is not zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>

        public static void NotZero(uint actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.NotZero(actual, message, args));
        }

        /// <summary>
        /// Asserts that a Long is not zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        public static void NotZero(long actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.NotZero(actual));
        }

        /// <summary>
        /// Asserts that a Long is not zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void NotZero(long actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.NotZero(actual, message, args));
        }

        /// <summary>
        /// Asserts that an unsigned Long is not zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>

        public static void NotZero(ulong actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.NotZero(actual));
        }

        /// <summary>
        /// Asserts that an unsigned Long is not zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>

        public static void NotZero(ulong actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.NotZero(actual, message, args));
        }

        /// <summary>
        /// Asserts that a decimal is zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        public static void NotZero(decimal actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.NotZero(actual));
        }

        /// <summary>
        /// Asserts that a decimal is zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void NotZero(decimal actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.NotZero(actual, message, args));
        }

        /// <summary>
        /// Asserts that a double is zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        public static void NotZero(double actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.NotZero(actual));
        }

        /// <summary>
        /// Asserts that a double is zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void NotZero(double actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.NotZero(actual, message, args));
        }

        /// <summary>
        /// Asserts that a float is zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        public static void NotZero(float actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.NotZero(actual));
        }

        /// <summary>
        /// Asserts that a float is zero.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void NotZero(float actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.NotZero(actual, message, args));
        }

        /// <summary>
        /// Asserts that an int is positive.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        public static void Positive(int actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Positive(actual));
        }

        /// <summary>
        /// Asserts that an int is positive.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Positive(int actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Positive(actual, message, args));
        }

        /// <summary>
        /// Asserts that an unsigned int is positive.
        /// </summary>
        /// <param name="actual">The number to be examined</param>

        public static void Positive(uint actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Positive(actual));
        }

        /// <summary>
        /// Asserts that an unsigned int is positive.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>

        public static void Positive(uint actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Positive(actual, message, args));
        }

        /// <summary>
        /// Asserts that a Long is positive.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        public static void Positive(long actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Positive(actual));
        }

        /// <summary>
        /// Asserts that a Long is positive.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Positive(long actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Positive(actual, message, args));
        }

        /// <summary>
        /// Asserts that an unsigned Long is positive.
        /// </summary>
        /// <param name="actual">The number to be examined</param>

        public static void Positive(ulong actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Positive(actual));
        }

        /// <summary>
        /// Asserts that an unsigned Long is positive.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>

        public static void Positive(ulong actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Positive(actual, message, args));
        }

        /// <summary>
        /// Asserts that a decimal is positive.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        public static void Positive(decimal actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Positive(actual));
        }

        /// <summary>
        /// Asserts that a decimal is positive.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Positive(decimal actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Positive(actual, message, args));
        }

        /// <summary>
        /// Asserts that a double is positive.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        public static void Positive(double actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Positive(actual));
        }

        /// <summary>
        /// Asserts that a double is positive.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Positive(double actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Positive(actual, message, args));
        }

        /// <summary>
        /// Asserts that a float is positive.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        public static void Positive(float actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Positive(actual));
        }

        /// <summary>
        /// Asserts that a float is positive.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Positive(float actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Positive(actual, message, args));
        }

        /// <summary>
        /// Asserts that an int is negative.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        public static void Negative(int actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Negative(actual));
        }

        /// <summary>
        /// Asserts that an int is negative.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Negative(int actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Negative(actual, message, args));
        }

        /// <summary>
        /// Asserts that an unsigned int is negative.
        /// </summary>
        /// <param name="actual">The number to be examined</param>

        public static void Negative(uint actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Negative(actual));
        }

        /// <summary>
        /// Asserts that an unsigned int is negative.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>

        public static void Negative(uint actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Negative(actual, message, args));
        }

        /// <summary>
        /// Asserts that a Long is negative.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        public static void Negative(long actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Negative(actual));
        }

        /// <summary>
        /// Asserts that a Long is negative.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Negative(long actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Negative(actual, message, args));
        }

        /// <summary>
        /// Asserts that an unsigned Long is negative.
        /// </summary>
        /// <param name="actual">The number to be examined</param>

        public static void Negative(ulong actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Negative(actual));
        }

        /// <summary>
        /// Asserts that an unsigned Long is negative.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>

        public static void Negative(ulong actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Negative(actual, message, args));
        }

        /// <summary>
        /// Asserts that a decimal is negative.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        public static void Negative(decimal actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Negative(actual));
        }

        /// <summary>
        /// Asserts that a decimal is negative.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Negative(decimal actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Negative(actual, message, args));
        }

        /// <summary>
        /// Asserts that a double is negative.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        public static void Negative(double actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Negative(actual));
        }

        /// <summary>
        /// Asserts that a double is negative.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Negative(double actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Negative(actual, message, args));
        }

        /// <summary>
        /// Asserts that a float is negative.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        public static void Negative(float actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Negative(actual));
        }

        /// <summary>
        /// Asserts that a float is negative.
        /// </summary>
        /// <param name="actual">The number to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Negative(float actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Negative(actual, message, args));
        }


        /// <summary>
        /// Throws a <see cref="T:NUnit.Framework.SuccessException" /> with the message and arguments
        /// that are passed in. This allows a test to be cut short, with a result
        /// of success returned to NUnit.
        /// </summary>
        /// <param name="message">The message to initialize the <see cref="T:NUnit.Framework.AssertionException" /> with.</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void Pass(string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Pass(message, args));
        }

        /// <summary>
        /// Throws a <see cref="T:NUnit.Framework.SuccessException" /> with the message and arguments
        /// that are passed in. This allows a test to be cut short, with a result
        /// of success returned to NUnit.
        /// </summary>
        /// <param name="message">The message to initialize the <see cref="T:NUnit.Framework.AssertionException" /> with.</param>
        public static void Pass(string message)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Pass(message));
        }

        /// <summary>
        /// Throws a <see cref="T:NUnit.Framework.SuccessException" /> with the message and arguments
        /// that are passed in. This allows a test to be cut short, with a result
        /// of success returned to NUnit.
        /// </summary>
        public static void Pass()
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Pass());
        }

        /// <summary>
        /// Throws an <see cref="T:NUnit.Framework.AssertionException" /> with the message and arguments
        /// that are passed in. This is used by the other Assert functions.
        /// </summary>
        /// <param name="message">The message to initialize the <see cref="T:NUnit.Framework.AssertionException" /> with.</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void Fail(string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Pass(message, args));
        }

        /// <summary>
        /// Throws an <see cref="T:NUnit.Framework.AssertionException" /> with the message that is
        /// passed in. This is used by the other Assert functions.
        /// </summary>
        /// <param name="message">The message to initialize the <see cref="T:NUnit.Framework.AssertionException" /> with.</param>
        public static void Fail(string message)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Fail(message));
        }

        /// <summary>
        /// Throws an <see cref="T:NUnit.Framework.AssertionException" />.
        /// This is used by the other Assert functions.
        /// </summary>
        public static void Fail()
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Fail());
        }

        /// <summary>
        /// Issues a warning using the message and arguments provided.
        /// </summary>
        /// <param name="message">The message to display.</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void Warn(string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Fail(message, args));
        }

        /// <summary>
        /// Issues a warning using the message provided.
        /// </summary>
        /// <param name="message">The message to display.</param>
        public static void Warn(string message)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Warn(message));
        }

        /// <summary>
        /// Throws an <see cref="T:NUnit.Framework.IgnoreException" /> with the message and arguments
        /// that are passed in.  This causes the test to be reported as ignored.
        /// </summary>
        /// <param name="message">The message to initialize the <see cref="T:NUnit.Framework.AssertionException" /> with.</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void Ignore(string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Warn(message, args));
        }

        /// <summary>
        /// Throws an <see cref="T:NUnit.Framework.IgnoreException" /> with the message that is
        /// passed in. This causes the test to be reported as ignored.
        /// </summary>
        /// <param name="message">The message to initialize the <see cref="T:NUnit.Framework.AssertionException" /> with.</param>
        public static void Ignore(string message)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Ignore(message));
        }

        /// <summary>
        /// Throws an <see cref="T:NUnit.Framework.IgnoreException" />.
        /// This causes the test to be reported as ignored.
        /// </summary>
        public static void Ignore()
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Ignore());
        }

        /// <summary>
        /// Throws an <see cref="T:NUnit.Framework.InconclusiveException" /> with the message and arguments
        /// that are passed in.  This causes the test to be reported as inconclusive.
        /// </summary>
        /// <param name="message">The message to initialize the <see cref="T:NUnit.Framework.InconclusiveException" /> with.</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void Inconclusive(string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Ignore(message, args));
        }

        /// <summary>
        /// Throws an <see cref="T:NUnit.Framework.InconclusiveException" /> with the message that is
        /// passed in. This causes the test to be reported as inconclusive.
        /// </summary>
        /// <param name="message">The message to initialize the <see cref="T:NUnit.Framework.InconclusiveException" /> with.</param>
        public static void Inconclusive(string message)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Inconclusive(message));
        }

        /// <summary>
        /// Throws an <see cref="T:NUnit.Framework.InconclusiveException" />.
        /// This causes the test to be reported as Inconclusive.
        /// </summary>
        public static void Inconclusive()
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Inconclusive());
        }

        /// <summary>
        /// Asserts that an object is contained in a collection.
        /// </summary>
        /// <param name="expected">The expected object</param>
        /// <param name="actual">The collection to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Contains(object expected, System.Collections.ICollection actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Contains(expected, actual, message, args));
        }

        /// <summary>
        /// Asserts that an object is contained in a collection.
        /// </summary>
        /// <param name="expected">The expected object</param>
        /// <param name="actual">The collection to be examined</param>
        public static void Contains(object expected, System.Collections.ICollection actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Contains(expected, actual));
        }
        /*
        /// <summary>
        /// Wraps code containing a series of assertions, which should all
        /// be executed, even if they fail. Failed results are saved and
        /// reported at the end of the code block.
        /// </summary>
        /// <param name="testDelegate">A TestDelegate to be executed in Multiple Assertion mode.</param>
        public static void Multiple(TestDelegate testDelegate)
        {
            Assert.Multiple(() => Assert.Multiple(testDelegate));
        }*/
        /*
        /// <summary>
        /// Wraps code containing a series of assertions, which should all
        /// be executed, even if they fail. Failed results are saved and
        /// reported at the end of the code block.
        /// </summary>
        /// <param name="testDelegate">A TestDelegate to be executed in Multiple Assertion mode.</param>
        public static void Multiple(AsyncTestDelegate testDelegate)
        {
            Assert.Multiple(() => Assert.Multiple(testDelegate));
        }*/

        /// <summary>
        /// Verifies that two doubles are equal considering a delta. If the
        /// expected value is infinity then the delta value is ignored. If 
        /// they are not equal then an <see cref="T:NUnit.Framework.AssertionException" /> is
        /// thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="delta">The maximum acceptable difference between the
        /// the expected and the actual</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreEqual(double expected, double actual, double delta, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.AreEqual(expected, actual, delta, message, args));
        }

        /// <summary>
        /// Verifies that two doubles are equal considering a delta. If the
        /// expected value is infinity then the delta value is ignored. If 
        /// they are not equal then an <see cref="T:NUnit.Framework.AssertionException" /> is
        /// thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="delta">The maximum acceptable difference between the
        /// the expected and the actual</param>
        public static void AreEqual(double expected, double actual, double delta)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.AreEqual(expected, actual, delta));
        }

        /// <summary>
        /// Verifies that two doubles are equal considering a delta. If the
        /// expected value is infinity then the delta value is ignored. If 
        /// they are not equal then an <see cref="T:NUnit.Framework.AssertionException" /> is
        /// thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="delta">The maximum acceptable difference between the
        /// the expected and the actual</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreEqual(double expected, double? actual, double delta, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.AreEqual(expected, actual, delta, message, args));
        }

        /// <summary>
        /// Verifies that two doubles are equal considering a delta. If the
        /// expected value is infinity then the delta value is ignored. If 
        /// they are not equal then an <see cref="T:NUnit.Framework.AssertionException" /> is
        /// thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="delta">The maximum acceptable difference between the
        /// the expected and the actual</param>
        public static void AreEqual(double expected, double? actual, double delta)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.AreEqual(expected, actual, delta));
        }

        /// <summary>
        /// Verifies that two objects are equal.  Two objects are considered
        /// equal if both are null, or if both have the same value. NUnit
        /// has special semantics for some object types.
        /// If they are not equal an <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The value that is expected</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreEqual(object expected, object actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.AreEqual(expected, actual, message, args));
        }

        /// <summary>
        /// Verifies that two objects are equal.  Two objects are considered
        /// equal if both are null, or if both have the same value. NUnit
        /// has special semantics for some object types.
        /// If they are not equal an <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The value that is expected</param>
        /// <param name="actual">The actual value</param>
        public static void AreEqual(object expected, object actual)
        {
            Assert.Multiple(() => areEqual(expected, actual));
        }

        public static void areEqual(object expected, object actual)
        {
            Console.WriteLine(expected + " " + actual);
            Assert.AreEqual(expected, actual);
        }

        public static void areEqual(object expected, object actual, string message, params object[] args)
        {
            Console.WriteLine(expected + " " + actual + " " + message);
            Assert.AreEqual(expected, actual, message, args);
        }

        /// <summary>
        /// Verifies that two objects are not equal.  Two objects are considered
        /// equal if both are null, or if both have the same value. NUnit
        /// has special semantics for some object types.
        /// If they are equal an <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The value that is expected</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreNotEqual(object expected, object actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.AreNotEqual(expected, actual, message, args));
        }

        /// <summary>
        /// Verifies that two objects are not equal.  Two objects are considered
        /// equal if both are null, or if both have the same value. NUnit
        /// has special semantics for some object types.
        /// If they are equal an <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The value that is expected</param>
        /// <param name="actual">The actual value</param>
        public static void AreNotEqual(object expected, object actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.AreNotEqual(expected, actual));
        }

        /// <summary>
        /// Asserts that two objects refer to the same object. If they
        /// are not the same an <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected object</param>
        /// <param name="actual">The actual object</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreSame(object expected, object actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.AreSame(expected, actual, message, args));
        }

        /// <summary>
        /// Asserts that two objects refer to the same object. If they
        /// are not the same an <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected object</param>
        /// <param name="actual">The actual object</param>
        public static void AreSame(object expected, object actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.AreSame(expected, actual));
        }

        /// <summary>
        /// Asserts that two objects do not refer to the same object. If they
        /// are the same an <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected object</param>
        /// <param name="actual">The actual object</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreNotSame(object expected, object actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.AreNotSame(expected, actual, message, args));
        }

        /// <summary>
        /// Asserts that two objects do not refer to the same object. If they
        /// are the same an <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected object</param>
        /// <param name="actual">The actual object</param>
        public static void AreNotSame(object expected, object actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.AreNotSame(expected, actual));
        }

        /// <summary>
        /// Verifies that an async delegate throws a particular exception when called.
        /// </summary>
        /// <param name="expression">A constraint to be satisfied by the exception</param>
        /// <param name="code">A TestSnippet delegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void ThrowsAsync(NUnit.Framework.Constraints.IResolveConstraint expression, AsyncTestDelegate code, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.ThrowsAsync(expression, code, message, args));
        }

        /// <summary>
        /// Verifies that an async delegate throws a particular exception when called.
        /// </summary>
        /// <param name="expression">A constraint to be satisfied by the exception</param>
        /// <param name="code">A TestSnippet delegate</param>
        public static void ThrowsAsync(NUnit.Framework.Constraints.IResolveConstraint expression, AsyncTestDelegate code)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.ThrowsAsync(expression, code));
        }
        /// <summary>
        /// Verifies that an async delegate throws a particular exception when called.
        /// </summary>
        /// <param name="expectedExceptionType">The exception Type expected</param>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void ThrowsAsync(Type expectedExceptionType, AsyncTestDelegate code, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.ThrowsAsync(expectedExceptionType, code, message, args));
        }

        /// <summary>
        /// Verifies that an async delegate throws a particular exception when called.
        /// </summary>
        /// <param name="expectedExceptionType">The exception Type expected</param>
        /// <param name="code">A TestDelegate</param>
        public static void ThrowsAsync(Type expectedExceptionType, AsyncTestDelegate code)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.ThrowsAsync(expectedExceptionType, code));
        }

        /// <summary>
        /// Verifies that an async delegate throws a particular exception when called.
        /// </summary>
        /// <typeparam name="TActual">Type of the expected exception</typeparam>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void ThrowsAsync<TActual>(AsyncTestDelegate code, string message, params object[] args) where TActual : Exception
        {
            Assert.Multiple(() => NUnit.Framework.Assert.ThrowsAsync<TActual>(code, message, args));
        }

        /// <summary>
        /// Verifies that an async delegate throws a particular exception when called.
        /// </summary>
        /// <typeparam name="TActual">Type of the expected exception</typeparam>
        /// <param name="code">A TestDelegate</param>
        public static void ThrowsAsync<TActual>(AsyncTestDelegate code) where TActual : Exception
        {
            Assert.Multiple(() => NUnit.Framework.Assert.ThrowsAsync<TActual>(code));
        }

        /// <summary>
        /// Verifies that an async delegate throws an exception when called
        /// and returns it.
        /// </summary>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void CatchAsync(AsyncTestDelegate code, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.CatchAsync(code, message, args));
        }

        /// <summary>
        /// Verifies that an async delegate throws an exception when called
        /// and returns it.
        /// </summary>
        /// <param name="code">A TestDelegate</param>
        public static void CatchAsync(AsyncTestDelegate code)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.CatchAsync(code));
        }

        /// <summary>
        /// Verifies that an async delegate throws an exception of a certain Type
        /// or one derived from it when called and returns it.
        /// </summary>
        /// <param name="expectedExceptionType">The expected Exception Type</param>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void CatchAsync(Type expectedExceptionType, AsyncTestDelegate code, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.CatchAsync(expectedExceptionType, code, message, args));
        }

        /// <summary>
        /// Verifies that an async delegate throws an exception of a certain Type
        /// or one derived from it when called and returns it.
        /// </summary>
        /// <param name="expectedExceptionType">The expected Exception Type</param>
        /// <param name="code">A TestDelegate</param>
        public static void CatchAsync(Type expectedExceptionType, AsyncTestDelegate code)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.CatchAsync(expectedExceptionType, code));
        }

        /// <summary>
        /// Verifies that an async delegate throws an exception of a certain Type
        /// or one derived from it when called and returns it.
        /// </summary>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void CatchAsync<TActual>(AsyncTestDelegate code, string message, params object[] args) where TActual : Exception
        {
            Assert.Multiple(() => NUnit.Framework.Assert.CatchAsync<TActual>(code, message, args));
        }

        /// <summary>
        /// Verifies that an async delegate throws an exception of a certain Type
        /// or one derived from it when called and returns it.
        /// </summary>
        /// <param name="code">A TestDelegate</param>
        public static void CatchAsync<TActual>(AsyncTestDelegate code) where TActual : Exception
        {
            Assert.Multiple(() => NUnit.Framework.Assert.CatchAsync<TActual>(code));
        }

        /// <summary>
        /// Verifies that an async delegate does not throw an exception
        /// </summary>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void DoesNotThrowAsync(AsyncTestDelegate code, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.DoesNotThrowAsync(code, message, args));
        }

        /// <summary>
        /// Verifies that an async delegate does not throw an exception.
        /// </summary>
        /// <param name="code">A TestDelegate</param>
        public static void DoesNotThrowAsync(AsyncTestDelegate code)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.DoesNotThrowAsync(code));
        }

        /// <summary>
        /// Verifies that a delegate throws a particular exception when called.
        /// </summary>
        /// <param name="expression">A constraint to be satisfied by the exception</param>
        /// <param name="code">A TestSnippet delegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void Throws(NUnit.Framework.Constraints.IResolveConstraint expression, TestDelegate code, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Throws(expression, code, message, args));
        }

        /// <summary>
        /// Verifies that a delegate throws a particular exception when called.
        /// </summary>
        /// <param name="expression">A constraint to be satisfied by the exception</param>
        /// <param name="code">A TestSnippet delegate</param>
        public static void Throws(NUnit.Framework.Constraints.IResolveConstraint expression, TestDelegate code)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Throws(expression, code));
        }

        /// <summary>
        /// Verifies that a delegate throws a particular exception when called.
        /// </summary>
        /// <param name="expectedExceptionType">The exception Type expected</param>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void Throws(Type expectedExceptionType, TestDelegate code, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Throws(expectedExceptionType, code, message, args));
        }

        /// <summary>
        /// Verifies that a delegate throws a particular exception when called.
        /// </summary>
        /// <param name="expectedExceptionType">The exception Type expected</param>
        /// <param name="code">A TestDelegate</param>
        public static void Throws(Type expectedExceptionType, TestDelegate code)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Throws(expectedExceptionType, code));
        }

        /// <summary>
        /// Verifies that a delegate throws a particular exception when called.
        /// </summary>
        /// <typeparam name="TActual">Type of the expected exception</typeparam>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void Throws<TActual>(TestDelegate code, string message, params object[] args) where TActual : Exception
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Throws<TActual>(code, message, args));
        }

        /// <summary>
        /// Verifies that a delegate throws a particular exception when called.
        /// </summary>
        /// <typeparam name="TActual">Type of the expected exception</typeparam>
        /// <param name="code">A TestDelegate</param>
        public static void Throws<TActual>(TestDelegate code) where TActual : Exception
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Throws<TActual>(code));
        }

        /// <summary>
        /// Verifies that a delegate throws an exception when called
        /// and returns it.
        /// </summary>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void Catch(TestDelegate code, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Catch(code, message, args));
        }

        /// <summary>
        /// Verifies that a delegate throws an exception when called
        /// and returns it.
        /// </summary>
        /// <param name="code">A TestDelegate</param>
        public static void Catch(TestDelegate code)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Catch(code));
        }

        /// <summary>
        /// Verifies that a delegate throws an exception of a certain Type
        /// or one derived from it when called and returns it.
        /// </summary>
        /// <param name="expectedExceptionType">The expected Exception Type</param>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void Catch(Type expectedExceptionType, TestDelegate code, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Catch(expectedExceptionType, code, message, args));
        }

        /// <summary>
        /// Verifies that a delegate throws an exception of a certain Type
        /// or one derived from it when called and returns it.
        /// </summary>
        /// <param name="expectedExceptionType">The expected Exception Type</param>
        /// <param name="code">A TestDelegate</param>
        public static void Catch(Type expectedExceptionType, TestDelegate code)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Catch(expectedExceptionType, code));
        }

        /// <summary>
        /// Verifies that a delegate throws an exception of a certain Type
        /// or one derived from it when called and returns it.
        /// </summary>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void Catch<TActual>(TestDelegate code, string message, params object[] args) where TActual : Exception
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Catch<TActual>(code, message, args));
        }

        /// <summary>
        /// Verifies that a delegate throws an exception of a certain Type
        /// or one derived from it when called and returns it.
        /// </summary>
        /// <param name="code">A TestDelegate</param>
        public static void Catch<TActual>(TestDelegate code) where TActual : Exception
        {
            Assert.Multiple(() => NUnit.Framework.Assert.Catch<TActual>(code));
        }

        /// <summary>
        /// Verifies that a delegate does not throw an exception
        /// </summary>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void DoesNotThrow(TestDelegate code, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.DoesNotThrow(code, message, args));
        }

        /// <summary>
        /// Verifies that a delegate does not throw an exception.
        /// </summary>
        /// <param name="code">A TestDelegate</param>
        public static void DoesNotThrow(TestDelegate code)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.DoesNotThrow(code));
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary> 
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display if the condition is false</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void That(bool condition, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.That(condition, message, args));
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        public static void That(bool condition)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.That(condition));
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary> 
        /// <param name="condition">The evaluated condition</param>
        /// <param name="getExceptionMessage">A function to build the message included with the Exception</param>
        public static void That(bool condition, Func<string> getExceptionMessage)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.That(condition, getExceptionMessage));
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary> 
        /// <param name="condition">A lambda that returns a Boolean</param>
        /// <param name="message">The message to display if the condition is false</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void That(Func<bool> condition, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.That(condition, message, args));
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">A lambda that returns a Boolean</param>
        public static void That(Func<bool> condition)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.That(condition));
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary> 
        /// <param name="condition">A lambda that returns a Boolean</param>
        /// <param name="getExceptionMessage">A function to build the message included with the Exception</param>
        public static void That(Func<bool> condition, Func<string> getExceptionMessage)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.That(condition, getExceptionMessage));
        }

        /// <summary>
        /// Apply a constraint to an actual value, succeeding if the constraint
        /// is satisfied and throwing an assertion exception on failure.
        /// </summary>
        /// <typeparam name="TActual">The Type being compared.</typeparam>
        /// <param name="del">An NUnit.Framework.Constraints.ActualValueDelegate returning the value to be tested</param>
        /// <param name="expr">A Constraint expression to be applied</param>
        public static void That<TActual>(NUnit.Framework.Constraints.ActualValueDelegate<TActual> del, NUnit.Framework.Constraints.IResolveConstraint expr)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.That<TActual>(del, expr));
        }

        /// <summary>
        /// Apply a constraint to an actual value, succeeding if the constraint
        /// is satisfied and throwing an assertion exception on failure.
        /// </summary>
        /// <typeparam name="TActual">The Type being compared.</typeparam>
        /// <param name="del">An NUnit.Framework.Constraints.ActualValueDelegate returning the value to be tested</param>
        /// <param name="expr">A Constraint expression to be applied</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void That<TActual>(NUnit.Framework.Constraints.ActualValueDelegate<TActual> del, NUnit.Framework.Constraints.IResolveConstraint expr, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.That<TActual>(del, expr, message, args));
        }

        /// <summary>
        /// Apply a constraint to an actual value, succeeding if the constraint
        /// is satisfied and throwing an assertion exception on failure.
        /// </summary>
        /// <typeparam name="TActual">The Type being compared.</typeparam>
        /// <param name="del">An NUnit.Framework.Constraints.ActualValueDelegate returning the value to be tested</param>
        /// <param name="expr">A Constraint expression to be applied</param>
        /// <param name="getExceptionMessage">A function to build the message included with the Exception</param>
        public static void That<TActual>(NUnit.Framework.Constraints.ActualValueDelegate<TActual> del, NUnit.Framework.Constraints.IResolveConstraint expr, Func<string> getExceptionMessage)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.That<TActual>(del, expr, getExceptionMessage));
        }

        /// <summary>
        /// Asserts that the code represented by a delegate throws an exception
        /// that satisfies the constraint provided.
        /// </summary>
        /// <param name="code">A TestDelegate to be executed</param>
        /// <param name="constraint">A Constraint expression to be applied</param>
        public static void That(TestDelegate code, NUnit.Framework.Constraints.IResolveConstraint constraint)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.That(code, constraint));
        }

        /// <summary>
        /// Asserts that the code represented by a delegate throws an exception
        /// that satisfies the constraint provided.
        /// </summary>
        /// <param name="code">A TestDelegate to be executed</param>
        /// <param name="constraint">A Constraint expression to be applied</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void That(TestDelegate code, NUnit.Framework.Constraints.IResolveConstraint constraint, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.That(code, constraint, message, args));
        }

        /// <summary>
        /// Asserts that the code represented by a delegate throws an exception
        /// that satisfies the constraint provided.
        /// </summary>
        /// <param name="code">A TestDelegate to be executed</param>
        /// <param name="constraint">A Constraint expression to be applied</param>
        /// <param name="getExceptionMessage">A function to build the message included with the Exception</param>
        public static void That(TestDelegate code, NUnit.Framework.Constraints.IResolveConstraint constraint, Func<string> getExceptionMessage)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.That(code, constraint, getExceptionMessage));
        }

        /// <summary>
        /// Apply a constraint to an actual value, succeeding if the constraint
        /// is satisfied and throwing an assertion exception on failure.
        /// </summary>
        /// <typeparam name="TActual">The Type being compared.</typeparam>
        /// <param name="actual">The actual value to test</param>
        /// <param name="expression">A Constraint expression to be applied</param>
        public static void That<TActual>(TActual actual, NUnit.Framework.Constraints.IResolveConstraint expression)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.That<TActual>(actual, expression));
        }

        /// <summary>
        /// Apply a constraint to an actual value, succeeding if the constraint
        /// is satisfied and throwing an assertion exception on failure.
        /// </summary>
        /// <typeparam name="TActual">The Type being compared.</typeparam>
        /// <param name="actual">The actual value to test</param>
        /// <param name="expression">A Constraint expression to be applied</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void That<TActual>(TActual actual, NUnit.Framework.Constraints.IResolveConstraint expression, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.That<TActual>(actual, expression, message, args));
        }

        /// <summary>
        /// Apply a constraint to an actual value, succeeding if the constraint
        /// is satisfied and throwing an assertion exception on failure.
        /// </summary>
        /// <typeparam name="TActual">The Type being compared.</typeparam>
        /// <param name="actual">The actual value to test</param>
        /// <param name="expression">A Constraint expression to be applied</param>
        /// <param name="getExceptionMessage">A function to build the message included with the Exception</param>
        public static void That<TActual>(TActual actual, NUnit.Framework.Constraints.IResolveConstraint expression, Func<string> getExceptionMessage)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.That<TActual>(actual, expression, getExceptionMessage));
        }

        /// <summary>
        /// Apply a constraint to an actual value, succeeding if the constraint
        /// is satisfied and throwing an assertion exception on failure.
        /// Used as a synonym for That in rare cases where a private setter 
        /// causes a Visual Basic compilation error.
        /// </summary>
        /// <param name="actual">The actual value to test</param>
        /// <param name="expression">A Constraint expression to be applied</param>
        public static void ByVal(object actual, NUnit.Framework.Constraints.IResolveConstraint expression)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.ByVal(actual, expression));
        }

        /// <summary>
        /// Apply a constraint to an actual value, succeeding if the constraint
        /// is satisfied and throwing an assertion exception on failure. 
        /// Used as a synonym for That in rare cases where a private setter 
        /// causes a Visual Basic compilation error.
        /// </summary>
        /// <remarks>
        /// This method is provided for use by VB developers needing to test
        /// the value of properties with private setters.
        /// </remarks>
        /// <param name="actual">The actual value to test</param>
        /// <param name="expression">A Constraint expression to be applied</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void ByVal(object actual, NUnit.Framework.Constraints.IResolveConstraint expression, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.ByVal(actual, expression, message, args));
        }

        /// <summary>
        /// Asserts that an object may be assigned a value of a given Type.
        /// </summary>
        /// <param name="expected">The expected Type.</param>
        /// <param name="actual">The object under examination</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsAssignableFrom(Type expected, object actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsAssignableFrom(expected, actual, message, args));
        }

        /// <summary>
        /// Asserts that an object may be assigned a value of a given Type.
        /// </summary>
        /// <param name="expected">The expected Type.</param>
        /// <param name="actual">The object under examination</param>
        public static void IsAssignableFrom(Type expected, object actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsAssignableFrom(expected, actual));
        }

        /// <summary>
        /// Asserts that an object may be assigned a value of a given Type.
        /// </summary>
        /// <typeparam name="TExpected">The expected Type.</typeparam>
        /// <param name="actual">The object under examination</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsAssignableFrom<TExpected>(object actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsAssignableFrom<TExpected>(actual, message, args));
        }

        /// <summary>
        /// Asserts that an object may be assigned a value of a given Type.
        /// </summary>
        /// <typeparam name="TExpected">The expected Type.</typeparam>
        /// <param name="actual">The object under examination</param>
        public static void IsAssignableFrom<TExpected>(object actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsAssignableFrom<TExpected>(actual));
        }

        /// <summary>
        /// Asserts that an object may not be assigned a value of a given Type.
        /// </summary>
        /// <param name="expected">The expected Type.</param>
        /// <param name="actual">The object under examination</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsNotAssignableFrom(Type expected, object actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsNotAssignableFrom(expected, actual, message, args));
        }

        /// <summary>
        /// Asserts that an object may not be assigned a value of a given Type.
        /// </summary>
        /// <param name="expected">The expected Type.</param>
        /// <param name="actual">The object under examination</param>
        public static void IsNotAssignableFrom(Type expected, object actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsNotAssignableFrom(expected, actual));
        }

        /// <summary>
        /// Asserts that an object may not be assigned a value of a given Type.
        /// </summary>
        /// <typeparam name="TExpected">The expected Type.</typeparam>
        /// <param name="actual">The object under examination</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsNotAssignableFrom<TExpected>(object actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsNotAssignableFrom<TExpected>(actual, message, args));
        }

        /// <summary>
        /// Asserts that an object may not be assigned a value of a given Type.
        /// </summary>
        /// <typeparam name="TExpected">The expected Type.</typeparam>
        /// <param name="actual">The object under examination</param>
        public static void IsNotAssignableFrom<TExpected>(object actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsNotAssignableFrom<TExpected>(actual));
        }

        /// <summary>
        /// Asserts that an object is an instance of a given type.
        /// </summary>
        /// <param name="expected">The expected Type</param>
        /// <param name="actual">The object being examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsInstanceOf(Type expected, object actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsInstanceOf(expected, actual, message, args));
        }

        /// <summary>
        /// Asserts that an object is an instance of a given type.
        /// </summary>
        /// <param name="expected">The expected Type</param>
        /// <param name="actual">The object being examined</param>
        public static void IsInstanceOf(Type expected, object actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsInstanceOf(expected, actual));
        }

        /// <summary>
        /// Asserts that an object is an instance of a given type.
        /// </summary>
        /// <typeparam name="TExpected">The expected Type</typeparam>
        /// <param name="actual">The object being examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsInstanceOf<TExpected>(object actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsInstanceOf<TExpected>(actual, message, args));
        }

        /// <summary>
        /// Asserts that an object is an instance of a given type.
        /// </summary>
        /// <typeparam name="TExpected">The expected Type</typeparam>
        /// <param name="actual">The object being examined</param>
        public static void IsInstanceOf<TExpected>(object actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsInstanceOf<TExpected>(actual));
        }

        /// <summary>
        /// Asserts that an object is not an instance of a given type.
        /// </summary>
        /// <param name="expected">The expected Type</param>
        /// <param name="actual">The object being examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsNotInstanceOf(Type expected, object actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsNotInstanceOf(expected, actual, message, args));
        }

        /// <summary>
        /// Asserts that an object is not an instance of a given type.
        /// </summary>
        /// <param name="expected">The expected Type</param>
        /// <param name="actual">The object being examined</param>
        public static void IsNotInstanceOf(Type expected, object actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsNotInstanceOf(expected, actual));
        }

        /// <summary>
        /// Asserts that an object is not an instance of a given type.
        /// </summary>
        /// <typeparam name="TExpected">The expected Type</typeparam>
        /// <param name="actual">The object being examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsNotInstanceOf<TExpected>(object actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsNotInstanceOf<TExpected>(actual, message, args));
        }

        /// <summary>
        /// Asserts that an object is not an instance of a given type.
        /// </summary>
        /// <typeparam name="TExpected">The expected Type</typeparam>
        /// <param name="actual">The object being examined</param>
        public static void IsNotInstanceOf<TExpected>(object actual)
        {
            Assert.Multiple(() => NUnit.Framework.Assert.IsNotInstanceOf<TExpected>(actual));
        }
    }
}