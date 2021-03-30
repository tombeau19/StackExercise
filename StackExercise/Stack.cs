using System;
using System.Collections.Generic;
using System.Linq;

namespace StackExercise
{
    public class Stack
    {
        private List<object> _stackObjects = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("cannot add null");

            _stackObjects.Add(obj);
        }

        public object Pop()
        {
            if (_stackObjects.Count == 0)
                throw new InvalidOperationException("no items in stack");

            var last = _stackObjects.Last();
            _stackObjects.RemoveAt(_stackObjects.Count - 1);
            return last;
        }

        public void Clear()
        {
            if(_stackObjects.Count == 0)
                Console.WriteLine("already cleared");

            _stackObjects.Clear();
        }
    }
}