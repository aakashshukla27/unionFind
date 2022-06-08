using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    internal class WeightedQuickUnionPathCompression
    {
        private readonly int[] id; // access to component id (site indexed)
        private int count; // number of components
        private int[] size; // size of root components

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="n">Size of array</param>
        public WeightedQuickUnionPathCompression(int n)
        {
            count = n;
            id = Enumerable.Range(0, n).ToArray(); // n array accesses
            size = Enumerable.Repeat(1, n).ToArray();
        }

        /// <summary>
        /// Returns number of components
        /// </summary>
        /// <returns> total number of components </returns>
        public int Count() => count;

        /// <summary>
        /// Checks if 2 nodes are connected
        /// </summary>
        /// <param name="p">First Node</param>
        /// <param name="q">Second Node</param>
        /// <returns>Checks if the 2 components provided are connected</returns>
        public bool Connected(int p, int q) => Find(p) == Find(q);

        /// <summary>
        /// recursively gets id of current element till element is equal to id
        /// </summary>
        /// <param name="p">node number</param>
        /// <returns>root of the tree</returns>
        public int Find(int p)
        {
            while (p != id[p])
            {
                id[p] = id[id[p]];
                p = id[p];
            }
            return p;
        }

        /// <summary>
        /// Unions 2 integers, replaces id of first with id of second
        /// </summary>
        /// <param name="p">first node</param>
        /// <param name="q">second node</param>
        public void Union(int p, int q)
        {
            int pRoot = Find(p);
            int qRoot = Find(q);
            if (pRoot == qRoot) return;
            if(size[pRoot] < size[qRoot])
            {
                id[pRoot] = qRoot;
                size[qRoot] += size[pRoot];
            }
            else
            {
                id[qRoot] = pRoot;
                size[pRoot] += size[qRoot];
            }
            count--;
        }
    }
}
