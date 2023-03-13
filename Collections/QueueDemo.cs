using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class QueueDemo
    {
        public static void Queue()
        {
            Queue queue = new Queue();
            queue.Enqueue(12);
            queue.Enqueue(24);
            queue.Enqueue(36);
            queue.Enqueue(72);
            foreach (var ele in queue)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("The element present in queue: " + queue.Count);
            queue.Dequeue();
            Console.WriteLine(queue.Contains(30));
            foreach (var ele in queue)
            {
                Console.WriteLine(ele);
            }
            queue.Peek();
        }
    }
}
