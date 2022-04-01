using System;
using System.Collections.Generic;

namespace FizzSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = FizzBuzz(15);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            



        }


        public static IList<string> FizzBuzz(int n)
        {
            IList<string> donus = new List<string>();
            

            for (int i = 1; i <= n; i++)
            {
                string addMe = string.Empty;
                

                if (i % 3 == 0 && i%15!=0)
                {

                    addMe += "Fizz";

                }
                donus.Remove(i.ToString());
                if (i % 5 == 0 && i % 15 != 0)
                {
                    addMe += "Buzz";

                }
                donus.Remove(i.ToString());
                if (i % 3==0 && i%5 == 0)
                {
                    addMe += "FizzBuzz";

                }
                if (i%3 !=0 && i%5!=0)
                {
                    addMe = i.ToString();
                  
                }
                donus.Add(addMe);

               


            }

            return donus;

        }
    }

    

}
