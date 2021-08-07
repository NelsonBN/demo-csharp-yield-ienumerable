using System;
using System.Collections;
using System.Collections.Generic;

namespace Demo.Enumerable.FullImplementation
{
    public class SampleEnumerable : IEnumerable<int>, IDisposable
    {
        private readonly int _max;

        public SampleEnumerable(int max)
        {
            this._max = max;
        }

        public IEnumerator<int> GetEnumerator()
            => new SampleEnumerator(this._max);

        IEnumerator IEnumerable.GetEnumerator()
            => new SampleEnumerator(this._max);

        public void Dispose() { }
    }
}