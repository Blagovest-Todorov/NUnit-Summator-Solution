﻿
namespace Summator
{
    public static class Summator
    {
        public static long Sum(long[] arr)
        {
            long sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        public static long Average(long[] arr)
        {
            long sum = 0;            

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            long avg = sum /arr.Length;
            return avg;
        }
    }
}
