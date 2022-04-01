using System;
using System.Linq;

namespace RichestCustomer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };
            Console.WriteLine(maximumWealth(arr));
        }

        public static int maximumWealth(int[][] accounts)
        {
            int wealth = -1;
            for (int i = 0; i < accounts.Length; i++)
            {
                int temp_sum = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    temp_sum += accounts[i][j];
                }
                if (temp_sum > wealth)
                {
                    wealth = temp_sum;
                }
            }
            return wealth;
        }
    }
}

