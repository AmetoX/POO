using System;

namespace Project2
{
    internal class MyStack
    {
        int[] data;
        private int _capacity = 16;
        private int _count = 0;

        public bool IsEmpty { get { return _count == 0; } }
        public int Capacity { get { return _capacity; } }
        public int  Count { get { return _count; } }

        public MyStack()
        {
            data = new int[_capacity];
        }

        internal void Push(int v)
        {
            if (_count < _capacity)
            {
                data[_count] = v;
                _count++;
            }
            else
            {
                _capacity*=2;
                int [] vs = new int[_capacity];
                for(int i = 0; i < _count; i++)
                {
                    vs[i] = data[i];
                }
                data = vs;
            }
        }
    }
}