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
          


            
                Node fresh;
                fresh = new Node(element, null);
                fresh.next = top;
                top = fresh;
                Console.WriteLine("\n" + element + " pushed.");
            
        }
    
        public void pop()
        {
            Console.WriteLine("\nThe popped element is: " + top.info);
            top = top.next;
        }
        public void display()
        {
            Console.WriteLine();
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
            int[] davit = new int[27];
            int n;
            int i;
            string j;

            Stacks s = new Stacks();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***\n");
                Console.WriteLine("1. Push.");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your choice : ");
                Console.WriteLine("");
                Console.WriteLine("------------");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        while (true)
                        {
                            Console.Write("Enter of Numbers of Element in the Array : ");
                            j = Console.ReadLine();
                            n = Int32.Parse(j);
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
                            Console.Write("\nEnter a word: ");
                            string num = Convert.ToString(Console.ReadLine());
                            s.push(num);
                        }

                        break;
                    case '2':
                        if (s.empty())
                        {
                            Console.WriteLine("\nStack Empty");
                            break;
                        }
                        s.pop();
                        break;
                    case '3':
                        
                        Console.WriteLine("Items are : ");
                        s.display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }
            }
        }
    }
}








