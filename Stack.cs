using System;
using System.Collections;

namespace Stack
{
    public class Stack
    {
        object x;
        ArrayList list = new ArrayList();
        public int ElementIndex { get; private set; }
        public int ElementCount
        {
            get
            {
                return list.Count;
            }
            private set
            {
                ElementCount = list.Count;
            }
        }


        public void Push(object obj)
        {
            if (obj != null)
            {
                list.Add(obj);
            }
        }
        public object Pop()
        {
           if (list.Count >= 1)            
           {
               x = list[list.Count - 1];
               list.RemoveAt(list.Count-1);
               return x;
           }
           return null;
        }

        public object Peek()
        {
            if (list.Count > 0)
                return Convert.ToString(list[list.Count - 1]);
            return null;
        }

        public bool Peek(object x)
        {
            if ((list.Count > 0) & (list.Contains(x)))
            {
                ElementIndex = list.IndexOf(x);
                return true; 
            }
            if ((list.Count > 0) & (!list.Contains(x)))
            {
                return false;
            }
            else throw new InvalidOperationException();
        }

        public void Clear()
        {
            list.Clear();
        }
    }
}



