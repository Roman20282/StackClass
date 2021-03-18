using System;
using System.Collections;

namespace Stack
{
    public class Stack
    {
        object x;
        ArrayList list = new ArrayList();
        public int ElementCount { get; private set; }


        public void Push(object obj)
        {
            if (obj != null)
            {
                list.Add(obj);
                ElementCount++;
            }
            else
            {
                Console.WriteLine("InvalidOperationException: object can't be null. Element not added. Error:  -1 ");
            }
                
        }
        public object Pop()
        {
            if (ElementCount >= 1)                     
            {
                x = list[ElementCount-1];
                list[ElementCount - 1] = null;
                ElementCount--;
                return x;
            }
            else
            {
                Console.WriteLine("InvalidOperationException: Stack empty.  Error: ");
                return -1;
            }
        }

        public void Clear()
        {
            list.Clear();
            ElementCount = 0;

        }
    }
}
