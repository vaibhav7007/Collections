using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class SortedListDemo
    {
        public static void SortedList()
        {
            SortedList<string, string> sortedList = new SortedList<string, string>();
            sortedList.Add("a", "Shivani");
            sortedList.Add("k", "Malhar");
            sortedList.Add("s", "Shraddha");
            sortedList.Add("d", "Dadu");
            foreach (var element in sortedList)
            {
                Console.WriteLine(element.Key + " " + element.Value);
            }
            Console.WriteLine();
            sortedList.Remove("d");
            foreach (var element in sortedList)
            {
                Console.WriteLine(element.Key + " " + element.Value);
            }
        }
    }
}