using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNum
{
    class MaxNum
    {
        public int Maximum(int numOne, int numTwo, int numThree)
        {
            if (numOne.CompareTo(numTwo) > 0 && numOne.CompareTo(numThree) > 0)
            {
                return numOne;
            }
            else if (numTwo.CompareTo(numOne) > 0 && numTwo.CompareTo(numThree) > 0)
            {
                return numTwo;
            }
            else if (numThree.CompareTo(numTwo) > 0 && numThree.CompareTo(numOne) > 0)
            {
                return numThree;
            }
            else
            {
                Console.WriteLine("All number are same ");
                return 0;
            }
        }
    }
    class Program
    {
       public static void Main(string[] args)
       {
            MaxNum maxNum = new MaxNum();
            maxNum.Maximum(10, 25, 53);
            Console.WriteLine("The Maximum Number is: " + maxNum.Maximum(10, 25, 53));
       } 
    }
}