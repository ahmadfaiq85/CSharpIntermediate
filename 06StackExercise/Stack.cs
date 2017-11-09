using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExercise
{
    public class Stack
    {
        List<object> _stack = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Object cannot be null");
            _stack.Add(obj);
        }

        public object Pop()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException("No item in stack to Pop");

            object obj = _stack[_stack.Count - 1];
            _stack.Remove(obj);
            return obj;
        }
    }

}
