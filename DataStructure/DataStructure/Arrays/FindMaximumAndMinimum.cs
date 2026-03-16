using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Arrays
{
    public class FindMaximumAndMinimum
    {
        public void FindMaxMin(int[] intArray)
        {
            if (intArray.Length==0)
            {
                Console.WriteLine("Array is empty");
                return;
            }
            int min = intArray[0];
            int max = intArray[0];

            for (int i = 1; i < intArray.Length; i++) {

                if (intArray[i] < min)
                {
                    min = intArray[i];

                }
                if(intArray[i] > max)
                {
                    max = intArray[i];
                }

            }
        }
    }
}
