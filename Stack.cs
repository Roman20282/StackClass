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
           if (list.Count >= 1)            
            {
                x = list[list.Count - 1];
                list.RemoveAt(list.Count-1);
                ElementCount--;
                return x;
            }
           else 
            {
                Console.Write("InvalidOperationException: Stack empty!  Error: ");
                return -1;
            }
        }

        public object Peek()
        {
            if (list.Count > 0)
                return Convert.ToString(list[list.Count - 1]);
            else
            {
                Console.Write("InvalidOperationException: Stack empty!  Error: ");
                return -1;
            }
        }

        public void Peek(object x)
        {
            if ((list.Count > 0)&(list.Contains(x)))
            {
                Console.WriteLine("Element {0} is in stack. Index of this element: {1}", x, list.IndexOf(x));
            }
            else if ((list.Count > 0) & (!list.Contains(x)))
            {
                Console.Write("Element {0} in stack is absent", x);
            }
            else Console.WriteLine("InvalidOperationException: Stack empty! Error:  -1 ");
            
        }

        public void Clear()
        {
            list.Clear();
            ElementCount = 0;
        }
    }
}
