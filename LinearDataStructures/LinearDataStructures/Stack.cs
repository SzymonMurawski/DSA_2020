using System;
using System.Collections.Generic;
using System.Text;

namespace LinearDataStructures
{
    public class Stack
    {
        private int[] InternalArray;
        // Top of the stack == first node of InternalList
        private LinkedList InternalList;
        public int Count;
        public Stack()
        {
            Count = 0;
            InternalList = new LinkedList();
            InternalArray = new int[100];
        }
        // this should add a new element at the top of the stack
        public void Push(int value)
        {
            InternalList.AddFirst(value);
            Count++;
        }

        // this method should remove the element from the top of the stack and return it
        public int Pop()
        {
            if (Count == 0)
            {
                throw new NullReferenceException();
            }
            Count--;
            return InternalList.RemoveFirst();
        }

        public int Peek()
        {
            if (Count == 0)
            {
                throw new NullReferenceException();
            }
            return InternalList.First.Data;
        }
    }
}
