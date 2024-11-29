using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Single_Number
    {
        
        public static void Run()
        {
            int[] array = [2, 2, 1];
            int result = SingleNumber(array);
            Console.WriteLine(result);
        }


        public static int SingleNumber(int[] nums)
        {
           
            for (int i = 0; i < nums.Length; i++) 
            {
                bool isRepeated = false;

                for (int j = 0; j<nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        if (i != j)
                        {
                            isRepeated = true;
                        }
                    }
                    
                }


                if (!isRepeated)
                {
                    return nums[i];
                }
            }

            return 0;
        }
    }
}
