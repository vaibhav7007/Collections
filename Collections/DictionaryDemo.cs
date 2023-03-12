using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class DictionaryDemo
    {
        public static void Dictionary()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");
            dict.Add(4, "Four");
            foreach (KeyValuePair<int, string> element in dict)
            {
                Console.WriteLine("Key: " + element.Key + " " + "Value: " + element.Value);
            }
            Console.WriteLine("Elements present in Dictionary: " + dict.Count);
            dict.Remove(1);
            Console.WriteLine("Elements present in Dictionary: " + dict.Count);
            foreach (KeyValuePair<int, string> element in dict)
            {
                Console.WriteLine("Key: " + element.Key + " " + "Value: " + element.Value);
            }
        }
    }
}