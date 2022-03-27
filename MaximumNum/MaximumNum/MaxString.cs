using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNum
{
    class MaxString
    {
        public string MaximumString(string strOne, string strTwo, string strThree)
        {
           if(strOne.CompareTo(strTwo) > 0 && strOne.CompareTo(strThree) > 0)
           {
                return strOne;
           }
           else if (strTwo.CompareTo(strOne) > 0 && strTwo.CompareTo(strThree) > 0)
           {
                return strTwo;
           }
           else if (strThree.CompareTo(strTwo) > 0 && strThree.CompareTo(strOne) > 0)
           {
                return strThree;
           }
           else
           {
                Console.WriteLine("All three string are same");
                return null;
           }
        }
    }
}
