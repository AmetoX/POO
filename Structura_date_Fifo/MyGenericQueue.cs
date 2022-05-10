using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structura_date_Fifo
{
    internal class MyGenericQueue<T>
    {
        #region data
        private T[] data;
        private int left = 0;
        private int right = 0;
        private int count = 0;
        #endregion
        #region Ctors
        public MyGenericQueue() : this(42)
        {

        }
        public MyGenericQueue(int n)
        {
            data = new T[n];
        }
        #endregion
        #region Proprerties
        public bool Empty
        {
            get { return left == right; }
        }
        public int Count
        {
            get { return count; }
        }
        #endregion
        #region Methods
        public void Enqueue(T val)
        {
            if (count < data.Length)
            {
                if (right < data.Length)
                {
                    data[right++] = val;
                }
                else
                {
                    data[0] = val;
                    right = 1;
                }
                count++;
            }
            else
            {
                throw new QueueFullException("Coada este plina.");
            }
        }
        public T Dequeue()
        {
            T resutlt;
            if (count > 0)
            {
                resutlt = data[left];
                left = (left + 1) % data.Length;
                count--;
                return resutlt;
            }
            else
            {
                throw new QueueEmptyException("Coada este goala.");
            }
        }
        #endregion
    }
}
