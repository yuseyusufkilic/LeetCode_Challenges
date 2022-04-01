using System;

namespace StepsForNumZero
{
    class Program
    {
        static void Main(string[] args)
        {

            var result=NumberOfSteps(4);
            Console.WriteLine(result);
        }

        public static int NumberOfSteps(int num)

        {
            var steps = 0;

            while (num!=0)
            {
                if (num%2==1)
                {
                    num -= 1;
                    steps++;

                }
                if (num % 2 == 0 && num!=0)
                {
                    num /= 2;
                    steps++;
                }
            }
            return steps;

        }
    }
}
