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
        public void push(string element)
        {
            while (true)
            {
                Console.Write("Enter of Numbers of Element in the Array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 27))
                    break;
                else
                    Console.Write("\n Array should have minimun 1 and maximum 27 element. \n");
            }

            //Accept array element
            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("Enter Array Element ");
            Console.WriteLine("--------------------");

            for (i = 0; i < n; i++)
            {
                Node fresh;
                fresh = new Node(element, null);
                fresh.next = top;
                top = fresh;
                Console.WriteLine("\n" + element + " pushed.");
            }
        }
    
        public void pop()
        {
            Console.WriteLine("\nThe popped element is: " + top.info);
            top = top.next;
        }
        public void display()
        {
            Node tmp;
            if (empty())
                Console.WriteLine("\nStack Empty");
            else
            {
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
        }
    }
}








