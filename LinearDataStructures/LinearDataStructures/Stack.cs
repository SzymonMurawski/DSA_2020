using System;
using System.Collections.Generic;
using System.Text;

namespace LinearDataStructures
{
    public class Stack
    {
        private int[] InternalArray;
        public int Count;
        public Stack()
        {
            Count = 0;
            InternalArray = new int[100];
        }
        // this should add a new element at the top of the stack
        public void Push(int value)
        {
            InternalArray[Count] = value;
            Count++;
        }

        // this method should remove the element from the top of the stack and return it
        public int Pop()
        {
            if (Count == 0)
            {
                throw new NullReferenceException();
            }
            int returnValue = InternalArray[Count - 1];
            Count--;
            return returnValue;
        }

        public int Peek()
        {
            if (Count == 0)
            {
                throw new NullReferenceException();
            }
            return InternalArray[Count - 1];
        }
    }
}
