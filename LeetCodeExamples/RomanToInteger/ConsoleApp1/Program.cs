using System;
using System.Collections.Generic;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var result=ConvertToNum("LIX");
            Console.WriteLine(result);
            
        }
      
        public static int ConvertToNum(string romen)
        {
            var total = 0;
            var lastNum = 0;

            foreach (var romenChar in romen)
            {
                var current = MapConv(romenChar);

                if (current > lastNum)
                {
                    total -= lastNum * 2;
                }
                total += current;
                lastNum = current;


            }
            return total;

        }

        public static int MapConv(char r)
        {
            return _map[r];
        }

        public static Dictionary<char, int> _map = new Dictionary<char, int>()
            {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
            };
    }
}
