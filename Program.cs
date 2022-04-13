using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Welcome to Data Structures Programs");
            LinkedList linkedList = new LinkedList();
            Stack stack = new Stack();
            //stack.Push(70);
            //stack.Push(30);
            //stack.Push(56);

            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.Display();
            Console.ReadLine();
        }
    }
}
