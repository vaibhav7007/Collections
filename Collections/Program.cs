using System;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Collection programs");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:List Demo\n2:Dictionary Demo\n3:SortedList Demo\n4:Stack Demo\n5:Queue Demo\n6:ArrayList Demo\n7:HashTable Demo");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ListDemo.List();
                    break;
                case 2:
                    DictionaryDemo.Dictionary();
                    break;
                case 3:
                    SortedListDemo.SortedList();
                    break;
                case 4:
                    StackDemo.Stack();
                    break;
                case 5:
                    QueueDemo.Queue();
                    break;
                case 6:
                    ArrayListDemo.ArryList();
                    break;
                case 7:
                    HashTableDemo.Hashtable();
                    break;    
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}
