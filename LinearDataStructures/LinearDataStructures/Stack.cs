using System;
using System.Collections.Generic;
using System.Text;

namespace LinearDataStructures
{
    public class Stack<DataType>
    {
        // Top of the stack == first node of InternalList
        private LinkedList<DataType> InternalList;
        public int Count;
        public Stack()
        {
            Count = 0;
            InternalList = new LinkedList<DataType>();
        }
        // this should add a new element at the top of the stack
        public void Push(DataType value)
        {
            InternalList.AddFirst(value);
            Count++;
        }

        // this method should remove the element from the top of the stack and return it
        public DataType Pop()
        {
            if (Count == 0)
            {
                throw new NullReferenceException();
            }
            Count--;
            return InternalList.RemoveFirst();
        }

        public DataType Peek()
        {
            if (Count == 0)
            {
                throw new NullReferenceException();
            }
            return InternalList.First.Data;
        }
    }
}
