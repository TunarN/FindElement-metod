using System;

namespace MetodlarHometask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int num = 4;
            Console.WriteLine(FoundNum(nums,num));
        }
        static bool FoundNum(int[] nums, int num)
        {
            for (int i = 0; i <nums.Length; i++)
            {
                if (nums[i]==num)
                {
                    return true;
                }
               
            }
            return false;
        }
    }
}
