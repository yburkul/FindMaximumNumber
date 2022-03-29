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
            int[] Intarray = { 22, 55, 44, 77 ,38, 8 };
            MaxGeneric<int> maxGenericInt = new MaxGeneric<int>(Intarray);
            maxGenericInt.Maximum();

            float[] Floatarray = { 56.7f, 34.9f, 67.2f, 77.9f, 88.2f, 22.2f };
            MaxGeneric<float> maxGenericFloat = new MaxGeneric<float>(Floatarray);
            maxGenericFloat.Maximum();

            string[] Stringarray = { "Apple", "Banana", "Grapes", "Cherry", "Mango" };
            MaxGeneric<string> maxGenericString = new MaxGeneric<string>(Stringarray);
            maxGenericString.Maximum();
        }
    }
}