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
            MaxGeneric<int> generInt = new MaxGeneric<int>();
            generInt.Maximum(27, 88, 45);

            MaxGeneric<float> genericFloat = new MaxGeneric<float>();
            genericFloat.Maximum(66.2f, 55.5f, 34.8f);

            MaxGeneric<string> genericString = new MaxGeneric<string>();
            genericString.Maximum("Apple", "Peach", "Banana");
        }
    }
}