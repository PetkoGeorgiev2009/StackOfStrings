using System;
using System.Collections.Generic;
using System.Text;

namespace StackStrings_Upr
{
    internal class StackOfStrings
    {
        private List<string> data;

        public StackOfStrings()
        {
            data = new List<string>();
        }

        public void Push(string item)
        {
            data.Add(item);
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Стекът е празен!");
            }

            string item = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);

            return item;
        }

        public string Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Стекът е празен!");
            }

            return data[data.Count - 1];
        }

        public bool IsEmpty()
        {
            return data.Count == 0;
        }
    }
}
