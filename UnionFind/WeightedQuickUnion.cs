using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    internal class WeightedQuickUnion
    {
        private int[] id;
        private int[] size;
        private int count;

        public WeightedQuickUnion(int n)
        {
            count = n;
            id = Enumerable.Range(0, n).ToArray(); // n array accesses
            size =Enumerable.Repeat(1, n).ToArray();
        }

        public int Count() => count;

        public bool Connected(int p, int q) => Find(p) == Find(q);

        public int Find(int i)
        {
            while (i != id[i]) i = id[i];
            return i;
        }

        public void Union(int p, int q)
        {
            int i = Find(p);
            int j = Find(q);
            if (i == j) return;

            // Make smaller root point to larger node
            if(size[i] < size[j])
            {
                id[i] = j;
                size[j] += size[i];
            }
            else
            {
                id[j] = i;
                size[i] += size[j];
            }
            count--;
        }


    }
}
