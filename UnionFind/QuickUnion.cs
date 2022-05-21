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

        /// <summary>
        /// Constructor initialize an array of n elements ranging from 0 to n
        /// </summary>
        /// <param name="n"></param>
        public QuickUnion(int n)
        {
            id = Enumerable.Range(0, n).ToArray(); // n array accesses
        }

        /// <summary>
        /// change parent pointers until you reach root as that points to itself
        /// </summary>
        /// <param name="i"></param>
        /// <returns> root node of i</returns>
        private int Root(int i)
        {
            while (i != id[i]) i = id[i]; // depth of i array accesses
            return i;
        }

        /// <summary>
        /// finds if root of 2 supplied nodes are equal
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);   // depth of p and q array accesses
        }


        public void Union(int p, int q)
        {
            id[Root(p)] = Root(q);  // change root of p to point to root of q
        }
    }
}
