using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Union_Find
{
    internal class UFQuickUnion: UF
    {
        public UFQuickUnion(int n): base(n)
        {

        }
        /// <summary>
        /// Stabileste o conexiune intre p si q
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        public override void union(int p, int q)
        {
            int pId = find(p);
            int qId = find(q);

            if (pId == qId)
                return;

            for (int i = 0; i < id.Length; i++)
                if (id[i] == pId)
                    id[i] = qId;

            componentNo--;

        }
        /// <summary>
        /// Determina componenta in care se afla p
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public override int find(int p)
        {
            return id[p];
        }
    }
}
