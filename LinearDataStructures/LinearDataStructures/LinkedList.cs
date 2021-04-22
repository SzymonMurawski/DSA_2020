using System;
using System.Collections.Generic;
using System.Text;

namespace LinearDataStructures
{
    public class LinkedList<DataType>
    {
        public LinkedListNode<DataType> First { get; set; }
        public LinkedListNode<DataType> Last { get; set; }
        public int Count { get; set; }
        public LinkedList()
        {
            Count = 0;
            First = null;
            Last = null;
        }
        public void AddLast(DataType value)
        {
            LinkedListNode<DataType> newNode = new LinkedListNode<DataType>(value);
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
        public void AddFirst(DataType value)
        {
            LinkedListNode<DataType> newNode = new LinkedListNode<DataType>(value);
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
        public DataType RemoveFirst()
        {
            DataType returnValue = First.Data;
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
