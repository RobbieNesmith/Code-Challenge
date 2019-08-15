using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odometer
{
    class Odometer
    {
        public static void Count(int[] arr, int change)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] > 9 || arr[i] < 0)
                {
                    throw new ArgumentException("Input array must only contain single digit non-negative integers.");
                }
                int sum = arr[i] + change;
                if (sum > 0)
                {
                    change = sum / 10;
                }
                else
                {
                    change = sum;
                }
                arr[i] = BetterMod(sum, 10);
            }
            if (change == 1 && arr.Length > 0)
            {
                arr[0] = 1;
            }
        }

        private static int BetterMod(int a, int b)
        {
            int modded = a % b;
            if (b > 0 && modded < 0)
            {
                while (modded < 0)
                {
                    modded += b;
                }
            }
            return modded;
        }
    }
}
