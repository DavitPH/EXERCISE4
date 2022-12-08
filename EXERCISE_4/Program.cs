using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Node
    {
        public string info;
        public Node next;
        public Node(string i, Node n)
        {
            info = i;
            next = n;
        }
    }

    class Stacks
    {
        int[] davit = new int [27];
        int n;
        int i;



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
       
    }
}








