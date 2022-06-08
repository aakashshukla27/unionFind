using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnionFind;
using Xunit;

namespace UnionFindTest
{
    public class QuickFindTest
    {
        [Fact]
        public void checkConnectedReturnsTrue()
        {
            QuickFind qf = new QuickFind(10);
            qf.Union(1, 2);
            qf.Union(3, 4);
            qf.Union(5, 6);

            Assert.True(qf.Connected(1, 2));
            Assert.True(qf.Connected(3, 4));
            Assert.True(qf.Connected(5, 6));
        }

        [Fact]
        public void checkConnectedReturnFalse()
        {
            QuickFind qf = new QuickFind(10);
            qf.Union(1, 2);
            qf.Union(3, 4);
            qf.Union(5, 6);

            Assert.False(qf.Connected(1, 5));
            Assert.False(qf.Connected(3, 5));
            Assert.False(qf.Connected(8, 1));
        }

    }
}
