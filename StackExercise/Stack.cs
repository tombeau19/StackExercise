using System;
using System.Collections.Generic;
using System.Linq;

namespace StackExercise
{
    public class Stack
    {
        public List<object> StackObjects { get; private set; }

        public Stack()
        {
            StackObjects = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("cannot add null");

            StackObjects.Add(obj);
        }

        public object Pop()
        {
            if (StackObjects.Count == 0)
                throw new InvalidOperationException("no items in stack");

            var last = StackObjects.Last();
            StackObjects.RemoveAt(StackObjects.Count - 1);
            return last;
        }

        public void Clear()
        {
            StackObjects.Clear();
        }
    }
}