using System;
using System.Collections.Generic;

namespace Socks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Merchant of Socks
            List<int> list = new List<int> { 6, 2, 9, 2, 6 };
            int result = sockMerchant(5, list);
            Console.WriteLine($"The merchant of Socks: {result}");

        }
        public static int sockMerchant(int n, List<int> ar)
        {
            List<int> list = new();
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (list.Contains(ar[i]))
                {
                    count++;
                    list.Remove(ar[i]);
                }
                else
                {
                    list.Add(ar[i]);
                }
            }
            return count;
        }

    }
}
