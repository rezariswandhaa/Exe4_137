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

        public void pop()
        {
            Console.WriteLine("\nThe popped element is: " + top.info);
            top = top.next; //Make top point to the next node in sequence
        }

        public void display()
        {
            Node tmp;

            if (empty())  //If stack is empty
                Console.WriteLine("\nStack Empty");
            else
            {
                //Traverse the list from beginning till end
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
                Console.WriteLine();
            }
        }
    }


}
