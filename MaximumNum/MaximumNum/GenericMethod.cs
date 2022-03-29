using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNum
{
    public class MaxGeneric<T> where T : IComparable
    {
        public T[] data;
        public MaxGeneric(T[] data)
        {
            this.data = data;
        }
        public T[] Sort(T[] data)
        {
            Array.Sort(data);
            return data;
        }
        public T Max(T[] data)
        {
            var sort_data = Sort(data);
            return sort_data[^1];
        }
        public T Maximum()
        {
            var max_data = Max(data);
            return max_data;
        }
        public T PrintMax()
        {
            var max_data = Max(data);
            Console.WriteLine("The Maximum value is: " + max_data);
            return max_data;
        }
    }
}
