using System;
using System.Collections.Generic;

namespace LinearDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> myList = new List<int>();
            myList.Add(123);
            myList.Add(3523);
            foreach (var item in myList){
                Console.WriteLine(item);
            }

            LinkedList<int> myList2 = new LinkedList<int>();
            myList2.AddLast(5);
            Console.WriteLine($"Value of last node is {myList2.Last.Data} and count of elements is {myList2.Count}");

            LinkedList<string> myList3 = new LinkedList<string>();
            myList3.AddFirst("asdfas");

        }
    }
}
