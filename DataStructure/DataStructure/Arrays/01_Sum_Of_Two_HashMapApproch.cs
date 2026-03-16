using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Arrays
{
    internal class _01_Sum_Of_Two_HashMapApproch
    {
        // find first two numbers in the array that add up to a specific target number.
        // target = 9
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        public static int[] Get(int[] array, int target)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                int num = target - array[i];

                if (dict.TryGetValue(num, out int j))
                {
                    return new int[] { j, i };
                }

                dict.Add(array[i], i);
            }

            return new int[0];
        }


    }

    //    Time Complexity: O(n)
    //        Why? Your code runs a single loop through the array:
    //        so 
    //        for (int i = 0; i<nums.Length; i++) So this part runs n times.
    //            Inside the loop you perform dictionary operations:
    //            dict.TryGetValue()
    //            dict.Add()
    //            Both operations in a Dictionary (Hash Table) take O(1) time on average.
   
}
