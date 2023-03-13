using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class HashTableDemo
    {
        public static void Hashtable()
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add(1, "One");
            hashTable.Add(2, "Two");
            hashTable.Add(3, "Three");
            hashTable.Add(4, "Four");
            foreach (DictionaryEntry ele in hashTable)
            {
                Console.WriteLine(ele.Key + " " + ele.Value);
            }
            Console.WriteLine("The number of element in HashTable is: " + hashTable.Count);
            hashTable.Remove(3);
            foreach (DictionaryEntry ele in hashTable)
            {
                Console.WriteLine(ele.Key + " " + ele.Value);
            }
        }
    }
}
