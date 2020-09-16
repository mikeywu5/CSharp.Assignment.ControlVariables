using System;

namespace NUnit.Framework.Multiples
{

    public class MultipleAssert
    {
        [OneTimeTearDown]
        public void MultipleTearDown()
        {
            MultipleAssertions.Instance.Dispose();
        }
    }
}
