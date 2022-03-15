using System;

namespace Project2
{
    internal class MyStack
    {
        int[] data;
        private int _capacity = 16;
        private int _count = 0;

        public int Capacity { get { return _capacity; } }
        public int  Count { get { return _count; } }
        public MyStack()
        {
            data = new int[_capacity];
        }

        internal void Push(int v)
        {
           
        }
    }
}