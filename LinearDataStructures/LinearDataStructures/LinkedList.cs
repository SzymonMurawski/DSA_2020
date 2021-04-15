using System;
using System.Collections.Generic;
using System.Text;

namespace LinearDataStructures
{
    class LinkedList
    {
        public LinkedListNode First { get; set; }
        public LinkedListNode Last { get; set; }
        public int Count { get; set; }
        public LinkedList()
        {
            Count = 0;
            First = null;
            Last = null;
        }
        public void AddLast(int value)
        {
            LinkedListNode newNode = new LinkedListNode(value);
            if(Last != null)
            {
                Last.Next = newNode;
            }
            if(First == null)
            {
                First = newNode;
            }
            Last = newNode;
            Count++;
        }
    }
}
