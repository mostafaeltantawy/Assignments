using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignADV02
{
    internal class FixedSizeList<T> 
    {
        private readonly int Size ;
        private readonly List<T> list;

        public FixedSizeList(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException( "Size must be greater than zero.");
            }

            Size = size;
            list = new List<T>(size);
        }

        public void Add(T item)
        {
            if(list.Count == Size)
            {
                throw new InvalidOperationException("The list is full"); 
            }
            list.Add(item);
        }

        public T Get(int index)
        {
            if(index < 0 || index >= list.Count)
            {
                throw new IndexOutOfRangeException("Enter valid index"); 
            }
            return list[index]; 
        }
    }
}
