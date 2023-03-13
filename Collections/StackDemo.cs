using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class StackDemo
    {
        public static void Stack()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            Console.WriteLine("The count of element is: " + stack.Count);
            foreach (int ele in stack)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("The top most element in stack: " + stack.Peek());
            Console.WriteLine("The element is remove in stack: " + stack.Pop());
            foreach (int ele in stack)
            {
                Console.WriteLine(ele);
            }
        }
    }
}