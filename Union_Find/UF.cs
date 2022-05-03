using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Union_Find
{
    internal abstract class UF
    {
        private int[] id;
        private int componentNo;
        /// <summary>
        /// Initializare
        /// </summary>
        /// <param name="n"></param>
        public UF(int n)
        {
            id = new int[n];
            componentNo = n;
            for (int i = 0; i < n; i++)
                id[i] = i;
        }
        /// <summary>
        /// Determina daca p si q sunt conectate
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public virtual bool connected(int p, int q)
        {
            return find(p) == find(q);
        }
        /// <summary>
        /// Determina componenta in care se afla p
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public abstract int find(int p);
        public abstract void union(int p, int q)
        public int count()
        {
            return componentNo;
        }
    }
}
