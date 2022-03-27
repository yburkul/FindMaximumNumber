using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNum
{
    class FloatMaxNum
    {
        public float MaxfloatNum(float numOne, float numTwo, float numThree)
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
}
