using System;
using System.Collections;
using System.Collections.Generic;

namespace Demo.Enumerable.FullImplementation
{
    public class SampleEnumerator : IEnumerator<int>, IDisposable
    {
        private readonly int _max;
        private int _current;
        private int _count;

        public int Current => this._current;
        object IEnumerator.Current => this._current;

        public SampleEnumerator(int max)
        {
            this._max = max;
            this.Reset();
            Console.WriteLine("\t> Before > loop");
        }

        public bool MoveNext()
        {
            if(this._count > 0)
            {
                Console.WriteLine($"\t\t» After > create > {this._current}");
            }

            if(this._count >= this._max)
            {
                return false;
            }
            else
            {
                Console.WriteLine($"\t\t» Before > create > {this._current}");

                this._current = this._count * 2;
                this._count++;
                return true;
            }
        }

        public void Reset()
        {
            this._count = 0;
            this._current = 0;
        }

        public void Dispose()
        {
            Console.WriteLine("\t> After > loop");
        }
    }
}