using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Generic Method");
            MaxGeneric<int> maxGenericInt = new MaxGeneric<int>(22, 55, 44);
            maxGenericInt.Maximum();

            MaxGeneric<float> maxGenericFloat = new MaxGeneric<float>(56.7f, 34.9f, 67.2f);
            maxGenericFloat.Maximum();

            MaxGeneric<string> maxGenericString = new MaxGeneric<string>("Apple", "Peach", "Banana");
            maxGenericString.Maximum();
        }
    }
}