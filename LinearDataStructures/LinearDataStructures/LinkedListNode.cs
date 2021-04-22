using System;
using System.Collections.Generic;
using System.Text;

namespace LinearDataStructures
{
    public class LinkedListNode<DataType>
    {
        public DataType Data { get; set; }
        public LinkedListNode<DataType> Next { get; set; }
        // Constructor 
        public LinkedListNode(DataType value)
        {
            Data = value;
            Next = null;
        }
    }
}
