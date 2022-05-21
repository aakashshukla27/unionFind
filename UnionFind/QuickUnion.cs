using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    internal class QuickUnion
    {
        private int[] id;

        public QuickUnion(int n)
        {
            id = Enumerable.Range(0, n).ToArray(); // n array accesses
        }

        private int Root(int i)
        {
            while (i != id[i]) i = id[i];
            return i;
        }

        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        public void Union(int p, int q)
        {
            id[Root(p)] = Root(q);
        }
    }
}
