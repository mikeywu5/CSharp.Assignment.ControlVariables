using System;
namespace NUnit.Framework.Multiples
{
    /// <summary>
    /// A set of Assert methods operating on one or more collections
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public abstract class CollectionAssert
    {
        /// <summary>
        /// Asserts that all items contained in collection are of the type specified by expectedType.
        /// </summary>
        /// <param name="collection">System.Collections.IEnumerable containing objects to be considered</param>
        /// <param name="expectedType">System.Type that all objects in collection must be instances of</param>
        public static void AllItemsAreInstancesOfType(System.Collections.IEnumerable collection, System.Type expectedType)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.AllItemsAreInstancesOfType(collection, expectedType));
        }

        /// <summary>
        /// Asserts that all items contained in collection are of the type specified by expectedType.
        /// </summary>
        /// <param name="collection">System.Collections.IEnumerable containing objects to be considered</param>
        /// <param name="expectedType">System.Type that all objects in collection must be instances of</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void AllItemsAreInstancesOfType(System.Collections.IEnumerable collection, System.Type expectedType, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.AllItemsAreInstancesOfType(collection, expectedType, message, args));
        }

        /// <summary>
        /// Asserts that all items contained in collection are not equal to null.
        /// </summary>
        /// <param name="collection">System.Collections.IEnumerable containing objects to be considered</param>
        public static void AllItemsAreNotNull(System.Collections.IEnumerable collection)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.AllItemsAreNotNull(collection));
        }

        /// <summary>
        /// Asserts that all items contained in collection are not equal to null.
        /// </summary>
        /// <param name="collection">System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void AllItemsAreNotNull(System.Collections.IEnumerable collection, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.AllItemsAreNotNull(collection, message, args));
        }

        /// <summary>
        /// Ensures that every object contained in collection exists within the collection
        /// once and only once.
        /// </summary>
        /// <param name="collection">System.Collections.IEnumerable of objects to be considered</param>
        public static void AllItemsAreUnique(System.Collections.IEnumerable collection)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.AllItemsAreUnique(collection));
        }

        /// <summary>
        /// Ensures that every object contained in collection exists within the collection
        /// once and only once.
        /// </summary>
        /// <param name="collection">System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void AllItemsAreUnique(System.Collections.IEnumerable collection, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.AllItemsAreUnique(collection, message, args));
        }

        /// <summary>
        /// Asserts that expected and actual are exactly equal.  The collections must have the same count, 
        /// and contain the exact same objects in the same order.
        /// </summary>
        /// <param name="expected">The first System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="actual">The second System.Collections.IEnumerable of objects to be considered</param>
        public static void AreEqual(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.AreEqual(expected, actual));
        }

        /// <summary>
        /// Asserts that expected and actual are exactly equal.  The collections must have the same count, 
        /// and contain the exact same objects in the same order.
        /// If comparer is not null then it will be used to compare the objects.
        /// </summary>
        /// <param name="expected">The first System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="actual">The second System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="comparer">The System.Collections.IComparer to use in comparing objects from each System.Collections.IEnumerable</param>
        public static void AreEqual(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual, System.Collections.IComparer comparer)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.AreEqual(expected, actual, comparer));
        }

        /// <summary>
        /// Asserts that expected and actual are exactly equal.  The collections must have the same count, 
        /// and contain the exact same objects in the same order.
        /// </summary>
        /// <param name="expected">The first System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="actual">The second System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void AreEqual(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.AreEqual(expected, actual, message, args));
        }

        /// <summary>
        /// Asserts that expected and actual are exactly equal.  The collections must have the same count, 
        /// and contain the exact same objects in the same order.
        /// If comparer is not null then it will be used to compare the objects.
        /// </summary>
        /// <param name="expected">The first System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="actual">The second System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="comparer">The System.Collections.IComparer to use in comparing objects from each System.Collections.IEnumerable</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void AreEqual(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual, System.Collections.IComparer comparer, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.AreEqual(expected, actual, comparer, message, args));
        }

        /// <summary>
        /// Asserts that expected and actual are equivalent, containing the same objects but the match may be in any order.
        /// </summary>
        /// <param name="expected">The first System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="actual">The second System.Collections.IEnumerable of objects to be considered</param>
        public static void AreEquivalent(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.AreEquivalent(expected, actual));
        }

        /// <summary>
        /// Asserts that expected and actual are equivalent, containing the same objects but the match may be in any order.
        /// </summary>
        /// <param name="expected">The first System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="actual">The second System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void AreEquivalent(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.AreEquivalent(expected, actual, message, args));
        }

        /// <summary>
        /// Asserts that expected and actual are not exactly equal.
        /// </summary>
        /// <param name="expected">The first System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="actual">The second System.Collections.IEnumerable of objects to be considered</param>
        public static void AreNotEqual(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.AreNotEqual(expected, actual));
        }

        /// <summary>
        /// Asserts that expected and actual are not exactly equal.
        /// If comparer is not null then it will be used to compare the objects.
        /// </summary>
        /// <param name="expected">The first System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="actual">The second System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="comparer">The System.Collections.IComparer to use in comparing objects from each System.Collections.IEnumerable</param>
        public static void AreNotEqual(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual, System.Collections.IComparer comparer)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.AreNotEqual(expected, actual, comparer));
        }

        /// <summary>
        /// Asserts that expected and actual are not exactly equal.
        /// </summary>
        /// <param name="expected">The first System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="actual">The second System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void AreNotEqual(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.AreNotEqual(expected, actual, message, args));
        }

        /// <summary>
        /// Asserts that expected and actual are not exactly equal.
        /// If comparer is not null then it will be used to compare the objects.
        /// </summary>
        /// <param name="expected">The first System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="actual">The second System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="comparer">The System.Collections.IComparer to use in comparing objects from each System.Collections.IEnumerable</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void AreNotEqual(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual, System.Collections.IComparer comparer, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.AreNotEqual(expected, actual, comparer, message, args));
        }

        /// <summary>
        /// Asserts that expected and actual are not equivalent.
        /// </summary>
        /// <param name="expected">The first System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="actual">The second System.Collections.IEnumerable of objects to be considered</param>
        public static void AreNotEquivalent(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.AreNotEquivalent(expected, actual));
        }

        /// <summary>
        /// Asserts that expected and actual are not equivalent.
        /// </summary>
        /// <param name="expected">The first System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="actual">The second System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void AreNotEquivalent(System.Collections.IEnumerable expected, System.Collections.IEnumerable actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.AreNotEquivalent(expected, actual, message, args));
        }

        /// <summary>
        /// Asserts that collection contains actual as an item.
        /// </summary>
        /// <param name="collection">System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="actual">Object to be found within collection</param>
        public static void Contains(System.Collections.IEnumerable collection, object actual)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.Contains(collection, actual));
        }

        /// <summary>
        /// Asserts that collection contains actual as an item.
        /// </summary>
        /// <param name="collection">System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="actual">Object to be found within collection</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void Contains(System.Collections.IEnumerable collection, object actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.Contains(collection, actual, message, args));
        }

        /// <summary>
        /// Asserts that collection does not contain actual as an item.
        /// </summary>
        /// <param name="collection">System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="actual">Object that cannot exist within collection</param>
        public static void DoesNotContain(System.Collections.IEnumerable collection, object actual)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.DoesNotContain(collection, actual));
        }

        /// <summary>
        /// Asserts that collection does not contain actual as an item.
        /// </summary>
        /// <param name="collection">System.Collections.IEnumerable of objects to be considered</param>
        /// <param name="actual">Object that cannot exist within collection</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void DoesNotContain(System.Collections.IEnumerable collection, object actual, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.DoesNotContain(collection, actual, message, args));
        }

        /// <summary>
        /// Asserts that the superset does not contain the subset
        /// </summary>
        /// <param name="subset">The System.Collections.IEnumerable subset to be considered</param>
        /// <param name="superset">The System.Collections.IEnumerable superset to be considered</param>
        public static void IsNotSubsetOf(System.Collections.IEnumerable subset, System.Collections.IEnumerable superset)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.IsNotSubsetOf(subset, superset));
        }

        /// <summary>
        /// Asserts that the superset does not contain the subset
        /// </summary>
        /// <param name="subset">The System.Collections.IEnumerable subset to be considered</param>
        /// <param name="superset">The System.Collections.IEnumerable superset to be considered</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void IsNotSubsetOf(System.Collections.IEnumerable subset, System.Collections.IEnumerable superset, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.IsNotSubsetOf(subset, superset, message, args));
        }

        /// <summary>
        /// Asserts that the superset contains the subset.
        /// </summary>
        /// <param name="subset">The System.Collections.IEnumerable subset to be considered</param>
        /// <param name="superset">The System.Collections.IEnumerable superset to be considered</param>
        public static void IsSubsetOf(System.Collections.IEnumerable subset, System.Collections.IEnumerable superset)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.IsSubsetOf(subset, superset));
        }

        /// <summary>
        /// Asserts that the superset contains the subset.
        /// </summary>
        /// <param name="subset">The System.Collections.IEnumerable subset to be considered</param>
        /// <param name="superset">The System.Collections.IEnumerable superset to be considered</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void IsSubsetOf(System.Collections.IEnumerable subset, System.Collections.IEnumerable superset, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.IsSubsetOf(subset, superset, message, args));
        }

        /// <summary>
        /// Asserts that the subset does not contain the superset
        /// </summary>
        /// <param name="superset">The System.Collections.IEnumerable superset to be considered</param>
        /// <param name="subset">The System.Collections.IEnumerable subset to be considered</param>
        public static void IsNotSupersetOf(System.Collections.IEnumerable superset, System.Collections.IEnumerable subset)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.IsNotSupersetOf(superset, subset));
        }

        /// <summary>
        /// Asserts that the subset does not contain the superset
        /// </summary>
        /// <param name="superset">The System.Collections.IEnumerable superset to be considered</param>
        /// <param name="subset">The System.Collections.IEnumerable subset to be considered</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void IsNotSupersetOf(System.Collections.IEnumerable superset, System.Collections.IEnumerable subset, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.IsNotSupersetOf(superset, subset, message, args));
        }

        /// <summary>
        /// Asserts that the subset contains the superset.
        /// </summary>
        /// <param name="superset">The System.Collections.IEnumerable superset to be considered</param>
        /// <param name="subset">The System.Collections.IEnumerable subset to be considered</param>
        public static void IsSupersetOf(System.Collections.IEnumerable superset, System.Collections.IEnumerable subset)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.IsSupersetOf(superset, subset));
        }

        /// <summary>
        /// Asserts that the subset contains the superset.
        /// </summary>
        /// <param name="superset">The System.Collections.IEnumerable superset to be considered</param>
        /// <param name="subset">The System.Collections.IEnumerable subset to be considered</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void IsSupersetOf(System.Collections.IEnumerable superset, System.Collections.IEnumerable subset, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.IsSupersetOf(superset, subset, message, args));
        }

        /// <summary>
        /// Assert that an array, list or other collection is empty
        /// </summary>
        /// <param name="collection">An array, list or other collection implementing System.Collections.IEnumerable</param>
        /// <param name="message">The message to be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void IsEmpty(System.Collections.IEnumerable collection, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.IsEmpty(collection, message, args));
        }

        /// <summary>
        /// Assert that an array,list or other collection is empty
        /// </summary>
        /// <param name="collection">An array, list or other collection implementing System.Collections.IEnumerable</param>
        public static void IsEmpty(System.Collections.IEnumerable collection)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.IsEmpty(collection));
        }

        /// <summary>
        /// Assert that an array, list or other collection is empty
        /// </summary>
        /// <param name="collection">An array, list or other collection implementing System.Collections.IEnumerable</param>
        /// <param name="message">The message to be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void IsNotEmpty(System.Collections.IEnumerable collection, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.IsNotEmpty(collection, message, args));
        }

        /// <summary>
        /// Assert that an array,list or other collection is empty
        /// </summary>
        /// <param name="collection">An array, list or other collection implementing System.Collections.IEnumerable</param>
        public static void IsNotEmpty(System.Collections.IEnumerable collection)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.IsNotEmpty(collection));
        }

        /// <summary>
        /// Assert that an array, list or other collection is ordered
        /// </summary>
        /// <param name="collection">An array, list or other collection implementing System.Collections.IEnumerable</param>
        /// <param name="message">The message to be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void IsOrdered(System.Collections.IEnumerable collection, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.IsOrdered(collection, message, args));
        }

        /// <summary>
        /// Assert that an array, list or other collection is ordered
        /// </summary>
        /// <param name="collection">An array, list or other collection implementing System.Collections.IEnumerable</param>
        public static void IsOrdered(System.Collections.IEnumerable collection)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.IsOrdered(collection));
        }

        /// <summary>
        /// Assert that an array, list or other collection is ordered
        /// </summary>
        /// <param name="collection">An array, list or other collection implementing System.Collections.IEnumerable</param>
        /// <param name="comparer">A custom comparer to perform the comparisons</param>
        /// <param name="message">The message to be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void IsOrdered(System.Collections.IEnumerable collection, System.Collections.IComparer comparer, string message, params object[] args)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.IsOrdered(collection, comparer, message, args));
        }
        [NUnit.Framework.TestAttribute]
        /// <summary>
        /// Assert that an array, list or other collection is ordered
        /// </summary>
        /// <param name="collection">An array, list or other collection implementing System.Collections.IEnumerable</param>
        /// <param name="comparer">A custom comparer to perform the comparisons</param>
        public static void IsOrdered(System.Collections.IEnumerable collection, System.Collections.IComparer comparer)
        {
            Assert.Multiple(() => NUnit.Framework.CollectionAssert.IsOrdered(collection, comparer));
        }
    }
}
