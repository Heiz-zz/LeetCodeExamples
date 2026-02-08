using System;

namespace LeetCode_Examples
{
    class container_with_most_water
    {
        public void CWMW()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int[] inputArray = input.ToString().Select(c => (int)char.GetNumericValue(c)).ToArray();

            int output = CWMWLogic(inputArray);
            System.Console.WriteLine(output);

            Thread.Sleep(2000);
        }

        int CWMWLogic(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxValue = 0;

            while(left < right)
            {
                int containerHeight = Math.Min(height[left], height[right]);
                int wight = right - left;

                int area = containerHeight * wight;

                maxValue = Math.Max(maxValue, area);

                if(height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxValue;
        }
    }
}