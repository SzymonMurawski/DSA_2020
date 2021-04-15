using System;
using System.Collections.Generic;
using System.Text;

namespace LinearDataStructures
{
    public class LinkedListNode
    {
        public int Data { get; set; }
        public LinkedListNode Next { get; set; }
        public LinkedListNode(int value)
        {
            Data = value;
            Next = null;
        }

    }
}
