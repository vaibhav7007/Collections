using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class ArrayListDemo
    {
        public static void ArryList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(35);
            arrayList.Add("Vaibhav");
            arrayList.Add(12.36f);
            arrayList.Add('h');
            arrayList.Add(45.369d);
            foreach (var ele in arrayList)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("The reverse element in queue");
            arrayList.Reverse();
            Console.WriteLine("The number of element in queue is: " + arrayList.Count);
            foreach (var ele in arrayList)
            {
                Console.WriteLine(ele);
            }
        }
    }
}