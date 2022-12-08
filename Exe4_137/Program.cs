using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_137
{
    class Node
    {
        public int info;
        public Node next;
        public Node(int mrr, Node n)
        {
            info = mrr;
            next = n;
        }
    }

    class Stacks
    {
        private int[] a = new int[58];

        Node top;

        public Stacks()
        {
            top = null;
        }
    }


}
