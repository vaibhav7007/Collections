using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class ListDemo
    {
        public static void List()
        {
            List<int> list = new List<int>();
            list.Add(13);
            list.Add(30);
            list.Add(10);
            list.Add(25);
            list.Add(63);
            list.Add(78);
            Console.WriteLine("The no of element present in list: " + list.Count);
            foreach (int elem in list)
            {
                Console.WriteLine(elem);
            }
            //list.Clear();
            Console.WriteLine("The no of element present in list: " + list.Count);
            Console.WriteLine(list.Contains(30));
            Console.WriteLine(list.Remove(10));
            list.Reverse();
            list.Sort();
            list.RemoveAt(2);
            foreach (int elem in list)
            {
                Console.WriteLine(elem);
            }
        }
    }
}