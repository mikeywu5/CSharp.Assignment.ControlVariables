using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace NUnit.Framework.Multiples
{
    internal class MultipleAssertions : IDisposable, IEnumerable<Action>
    {
        internal static readonly MultipleAssertions Instance = new MultipleAssertions();
        private readonly IDictionary<MethodBase, Action> _dictionary = new Dictionary<MethodBase, Action>();
        private readonly bool _autoCommit;
        private MethodBase _previousMethod = null;

        public MultipleAssertions(bool autoCommit = false)
        {
            _autoCommit = autoCommit;
        }

        public void Add(MethodBase testMethod, Action invocation)
        {
            Action tester;

            if (!_dictionary.TryGetValue(testMethod, out tester))
            {
                tester += invocation;
                _dictionary.Add(testMethod, tester);
            }
            else
            {
                _dictionary[testMethod] += invocation;
            }
            /*if (null != _previousMethod && !ReferenceEquals(_previousMethod, testMethod))
            {
                Invoke(_previousMethod);
            }*/
            _previousMethod = testMethod;
        }

        public void Invoke(MethodBase method)
        {
            if (!_dictionary.ContainsKey(method))
            {
                throw new KeyNotFoundException(method.ToString());
            }
            lock (_dictionary[method])
            {
                NUnit.Framework.Assert.Multiple(() => _dictionary[method]());
                _dictionary.Remove(method);
            }
        }

        public IEnumerator<Action> GetEnumerator()
        {
            return _dictionary.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {
            lock (_dictionary)
            {
                foreach (var tester in this)
                {
                    tester();
                    //               NUnit.Framework.Assert.Multiple(() => tester());
                }
                _dictionary.Clear();
            }
        }

        public Action this[MethodBase method]
        {
            get
            {
                return _dictionary[method];
            }
        }

        ~MultipleAssertions()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Dispose();
        }
    }
}