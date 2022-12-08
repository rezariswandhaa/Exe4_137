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

        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }

        public void push(int element)
        {
            Node fresh;
            fresh = new Node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + " pushed. ");
        }
    }


}
