using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNum
{
    class Program
    {
       public static void Main(string[] args)
       {
            MaxNum maxNum = new MaxNum();
            maxNum.Maximum(10, 25, 53);
            Console.WriteLine("The Maximum Number is: " + maxNum.Maximum(10, 25, 53));

            FloatMaxNum floatMaxNum = new FloatMaxNum();
            floatMaxNum.MaxfloatNum(77.6f, 88.4f, 56.4f);
            Console.WriteLine("The Maximum Float Number is: " + floatMaxNum.MaxfloatNum(77.6f, 88.4f, 56.4f));

            MaxString maxString = new MaxString();
            maxString.MaximumString("Apple", "Banana", "Peach");
            Console.WriteLine("The Maximum String is: " + maxString.MaximumString("Apple", "Peach", "Banana"));
       } 
    }
}