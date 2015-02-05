using System.Collections;
using System.Collections.Generic;

namespace MinerControl.Utility
{
    // Taken from http://stackoverflow.com/questions/6392516

    public class SlidingBuffer<T> : IEnumerable<T>
    {
        private readonly int _maxCount;
        private readonly Queue<T> _queue;

        public SlidingBuffer(int maxCount)
        {
            _maxCount = maxCount;
            _queue = new Queue<T>(maxCount);
        }

        public int Count
        {
            get { return _queue.Count; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _queue.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            if (_queue.Count == _maxCount)
                _queue.Dequeue();
            _queue.Enqueue(item);
        }
    }
}