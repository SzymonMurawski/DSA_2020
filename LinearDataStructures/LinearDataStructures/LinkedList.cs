using System;
using System.Collections.Generic;
using System.Text;

namespace LinearDataStructures
{
    public class LinkedList
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
        public void AddFirst(int value)
        {
            LinkedListNode newNode = new LinkedListNode(value);
            if(First != null)
            {
                newNode.Next = First;
            }
            First = newNode;
            if(Count == 0)
            {
                Last = newNode;
            }
            Count++;
        }
        public int RemoveFirst()
        {
            int returnValue = First.Data;
            First = First.Next;
            Count--;
            if(Count == 0)
            {
                Last = null;
            }
            return returnValue;
        }
    }
}
